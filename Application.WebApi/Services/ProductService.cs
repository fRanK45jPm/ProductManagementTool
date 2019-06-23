namespace Application.WebApi.Services
{
    using Application.WebApi.Services.Dtos;
    using Application.Logic.Managers;
    using Application.Logic.Managers.Candidates;
    using Unity;
    using Application.WebApi.Services.Mappers;
    using System.Collections.Generic;

    public class ProductService : IProductService
    {
        [Dependency]
        public IProductManager ProductManager { get; set; }

        public ProductDto Add(NewProductCandidate candidate)
        {
            return this.ProductManager.Add(candidate).ToProductDto();
        }

        public int Delete(int id)
        {
            return this.ProductManager.Delete(id);
        }

        public IEnumerable<ProductDto> GetAllProducts()
        {
            return this.ProductManager.GetAll().ToProductDto();
        }

        public ProductDto GetById(int id)
        {
            return this.ProductManager.GetById(id).ToProductDto();
        }

        public ProductDto Update(EditProductCandidate candidate)
        {
            return this.ProductManager.Update(candidate).ToProductDto();
        }
    }
}