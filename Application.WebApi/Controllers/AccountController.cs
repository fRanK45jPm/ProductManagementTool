namespace Application.WebApi.Controllers
{
    using System.Web.Http;
    using Application.Logic;
    using Application.Logic.Managers.Candidates;
    using Application.WebApi.Filters;
    using Application.WebApi.Services;
    using Unity;

    [TokenValidator]
    public class AccountController : ApiController
    {
        [Dependency]
        public IUserService UserService { get; set; }

        [Dependency]
        public IUserContext UserContext { get; set; }

        public IHttpActionResult Post(UserCandidate candidate)
        {
            return this.Ok(new
            {
                result = this.UserService.Add(candidate)
            });
        }

        public IHttpActionResult Get()
        {
            return this.Ok(new
            {
                result = this.UserService.GetAll()
            });
        }
    }
}