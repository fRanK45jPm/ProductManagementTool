namespace Application.Logic.Managers
{
    using System.Collections.Generic;
    using System.Linq;
    using Application.Data.Entities;
    using Application.Data.Repositories;
    using Application.Logic.Exceptions;
    using Application.Logic.Managers.Candidates;
    using Application.Logic.Validations;
    using Unity;

    public class ProductDisplayNameManager : BaseManager, IProductDisplayNameManager
    {
        [Dependency]
        public IProductDisplayNameRepository ProductDisplayNameRepository;

        [Dependency]
        public IProductRepository ProductRepository;

        [Dependency]
        public IUserContext UserContext;

        public ProductDisplayName AddNew(NewProductDisplayNameCandidate candidate)
        {
            return this.CreateAndSave(candidate);
        }

        public int DeleteById(int id)
        {
            return this.ProductDisplayNameRepository.DeleteById(id);
        }

        public ProductDisplayName GetById(int id)
        {
            return this.ProductDisplayNameRepository.GetById(id);
        }

        public IEnumerable<ProductDisplayName> GetByProductId(int productId)
        {
            var product = this.ProductRepository.GetByIdAndEnvironment(productId, this.UserContext.Environment);

            if (product == null)
            {
                return Enumerable.Empty<ProductDisplayName>();
            }

            return this.ProductDisplayNameRepository.GetProductDisplayNameByProductId(productId);
        }

        public ProductDisplayName UpdateById(EditProductDisplayNameCandidate candidate)
        {
            Guard.ArgumentIsNull(candidate, "candidate");
            Guard.ArgumentIsEmpty(candidate.LocaleName, "localename");

            var existing = this.ProductDisplayNameRepository.GetById(candidate.Id);

            if (existing == null)
            {
                throw new ProductDisplayNameDoesNotExistsException("Product name does not exists for this product.");
            }

            if (existing.Product.Environment != this.UserContext.Environment)
            {
                throw new ProductDoesNotExistsException();
            }

            existing.LocalDisplayName = candidate.LocaleName;
            this.Save();

            return existing;
        }

        private ProductDisplayName CreateAndSave(NewProductDisplayNameCandidate candidate)
        {
            Guard.ArgumentIsNull(candidate, "candidate");
            Guard.ArgumentIsEmpty((int)candidate.Language, "language");
            Guard.ArgumentIsEmpty(candidate.LocaleName, "LocaleName");

            var existing = this.ProductDisplayNameRepository
                .GetByProductIdAndLanguage(candidate.ProductId, candidate.Language);

            if (existing != null)
            {
                throw new ProductLocaleNameAlreadyExistsException();
            }

            var product = this.ProductRepository.GetByIdAndEnvironment(candidate.ProductId,
                this.UserContext.Environment);

            if (product == null)
            {
                throw new ProductDoesNotExistsException();
            }

            var entity = this.ProductDisplayNameRepository.Create();

            entity.Language = candidate.Language;
            entity.LocalDisplayName = candidate.LocaleName;
            entity.Product = this.ProductRepository.GetById(candidate.ProductId);

            this.Save();
            return entity;
        }
    }
}