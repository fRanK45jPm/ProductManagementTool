namespace Application.WebApi.Services
{
    using Application.Logic.Managers.Candidates;
    using Application.WebApi.Services.Dtos;

    public interface IProductDisplayNameService
    {
        ProductDisplayNameDto Add(NewProductDisplayNameCandidate candidate);

        ProductDisplayNameDto UpdateProductDisplayName(EditProductDisplayNameCandidate candidate);

        int Delete(int id);
    }
}