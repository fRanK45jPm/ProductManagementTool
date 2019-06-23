namespace Application.WebApi.Services
{
    using Application.WebApi.Services.Dtos;
    using Application.Logic.Managers.Candidates;
    using System.Collections.Generic;

    public interface IProductService
    {
        ProductDto Add(NewProductCandidate candidate);

        int Delete(int productId);

        IEnumerable<ProductDto> GetAllProducts();

        ProductDto GetById(int productId);

        ProductDto Update(EditProductCandidate candidate);
    }
}