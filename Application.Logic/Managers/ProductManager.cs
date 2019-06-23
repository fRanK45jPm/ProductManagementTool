namespace Application.Logic.Managers
{
    using System.Collections.Generic;
    using Application.Data.Entities;
    using Application.Data.Repositories;
    using Application.Logic.Exceptions;
    using Application.Logic.Managers.Candidates;
    using Application.Logic.Validations;
    using Unity;

    public class ProductManager : BaseManager, IProductManager
    {
        [Dependency]
        public IProductDisplayNameRepository ProductDisplayNameRepository { get; set; }

        [Dependency]
        public IProductRepository ProductRepository { get; set; }

        [Dependency]
        public IUserContext UserContext { get; set; }

        public Product Add(NewProductCandidate candidate)
        {
            Guard.ArgumentIsNull(candidate, "candidate");
            Guard.ArgumentIsEmpty(candidate.Name, "name");
            Guard.ArgumentIsEmpty(candidate.SKU, "SKU");

            return this.SaveAndCreate(candidate);
        }

        public int Delete(int id)
        {
            var existing = this.ProductRepository.GetByIdAndEnvironment(id, this.UserContext.Environment);

            if (existing == null)
            {
                throw new ProductDoesNotExistsException();
            }

            this.ProductDisplayNameRepository.DeleteByProductId(id);
            var result = this.ProductRepository.DeleteById(id);

            this.Save();
            return result;
        }

        public IEnumerable<Product> GetAll()
        {
            return this.ProductRepository.GetAll(this.UserContext.Environment);
        }

        public Product GetById(int id)
        {
            return this.ProductRepository.GetById(id);
        }

        public Product Update(EditProductCandidate candidate)
        {
            Guard.ArgumentIsNull(candidate, "candidate");
            Guard.ArgumentIsEmpty(candidate.Name, "name");
            Guard.ArgumentIsEmpty(candidate.SKU, "sku");

            return this.SaveAndUpdate(candidate);
        }

        private Product SaveAndCreate(NewProductCandidate candidate)
        {
            var entity = this.ProductRepository.Create();

            entity.Name = candidate.Name;
            entity.SKU = candidate.SKU;
            entity.Environment = this.UserContext.Environment;

            this.Save();
            return entity;
        }

        private Product SaveAndUpdate(EditProductCandidate candidate)
        {
            var existing = this.ProductRepository.GetById(candidate.Id);

            if (existing == null)
            {
                throw new ProductDoesNotExistsException();
            }

            if (existing.Environment != this.UserContext.Environment)
            {
                throw new ProductDoesNotExistsException();
            }

            existing.Name = candidate.Name;
            existing.SKU = candidate.SKU;

            this.Save();
            return existing;
        }
    }
}