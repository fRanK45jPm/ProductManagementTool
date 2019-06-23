namespace Application.WebApi.Services
{
    using Application.Logic.Managers;
    using Application.Logic.Managers.Candidates;
    using Application.WebApi.Services.Dtos;
    using Unity;
    using Application.WebApi.Services.Mappers;
    using Application.Logic;

    public class ProductDisplayNameService : IProductDisplayNameService
    {
        [Dependency]
        public IProductDisplayNameManager ProductDisplayNameManager { get; set; }

        [Dependency]
        public IUserContext UserContext { get; set; }

        public ProductDisplayNameDto Add(NewProductDisplayNameCandidate candidate)
        {
            return this.ProductDisplayNameManager.AddNew(candidate).ToProductDisplayNameDto();
        }

        public int Delete(int id)
        {
            return this.ProductDisplayNameManager.DeleteById(id);
        }

        public ProductDisplayNameDto UpdateProductDisplayName(EditProductDisplayNameCandidate candidate)
        {
            return this.ProductDisplayNameManager.UpdateById(candidate).ToProductDisplayNameDto();
        }
    }
}