namespace Application.WebApi.Controllers
{
    using System.Web.Http;
    using Application.Logic.Managers.Candidates;
    using Application.WebApi.Filters;
    using Application.WebApi.Services;
    using Unity;

    [TokenValidator]
    public class ProductDisplayNameController : ApiController
    {
        [Dependency]
        public IProductDisplayNameService ProductDisplayNameService { get; set; }

        public IHttpActionResult Post(NewProductDisplayNameCandidate candidate)
        {
             return this.Ok(new
            {
                result = this.ProductDisplayNameService.Add(candidate)
            });
        }

        public IHttpActionResult Put(EditProductDisplayNameCandidate candidate)
        {
            return this.Ok(new
            {
                result = this.ProductDisplayNameService.UpdateProductDisplayName(candidate)
            });
        }

        public IHttpActionResult Delete(int id)
        {
            return this.Ok(new
            {
                result = this.ProductDisplayNameService.Delete(id)
            });
        }
    }
}