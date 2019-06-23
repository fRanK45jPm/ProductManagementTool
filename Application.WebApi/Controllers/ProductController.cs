namespace Application.WebApi.Controllers
{
    using System.Web.Http;
    using Application.Logic.Managers.Candidates;
    using Application.WebApi.Filters;
    using Application.WebApi.Services;
    using Unity;

    [TokenValidator]
    public class ProductController : ApiController
    {
        [Dependency]
        public IProductService ProductService { get; set; }

        public IHttpActionResult Get()
        {
            return this.Ok(new
            {
                result = this.ProductService.GetAllProducts()
            });
        }

        public IHttpActionResult Get(int id)
        {
            return this.Ok(new
            {
                result = this.ProductService.GetById(id)
            });
        }

        public IHttpActionResult Post(NewProductCandidate value)
        {
            return this.Ok(new
            {
                result = this.ProductService.Add(value)
            });
        }

        public IHttpActionResult Put(EditProductCandidate value)
        {
            return this.Ok(new
            {
                result = this.ProductService.Update(value)
            });
        }

        public IHttpActionResult Delete(int id)
        {
            return this.Ok(new
            {
                result = this.ProductService.Delete(id)
            });
        }
    }
}