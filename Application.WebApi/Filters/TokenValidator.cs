namespace Application.WebApi.Filters
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http.Controllers;
    using System.Web.Http.Filters;
    using Application.Logic;
    using Application.Logic.Managers;
    using Unity;

    public class TokenValidatorAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            string query = actionContext.Request.RequestUri.Query;
            var nvc = System.Web.HttpUtility.ParseQueryString(query);
            string token = nvc["api_key"];

            var container = UnityConfig.Container;
            var userManager = container.Resolve<IUserManager>();
            var userContext = container.Resolve<IUserContext>();
            var user = userManager.GetUseyByToken(token);

            if (user == null)
            {
                actionContext.Response =
                    new HttpResponseMessage(HttpStatusCode.Unauthorized);
            }
            else
            {
                userContext.Environment = user.Environment;
                userContext.UserId = user.Id;

                base.OnActionExecuting(actionContext);
            }
        }
    }
}