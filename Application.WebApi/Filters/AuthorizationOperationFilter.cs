////namespace Application.WebApi.Filters
////{
////    using System;
////    using System.Collections.Generic;
////    using System.Web.Http.Description;
////    using Swashbuckle.Swagger;

////    public class AuthorizationOperationFilter : IOperationFilter
////    {
////        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
////        {
////            if (operation.parameters == null) {
////                operation.parameters = new List<Parameter>();
////            }

////            operation.parameters.Add(new Parameter
////            {
////             name =  "Authorization",
////             @in = "header",
////             description = "Access token",
////             required = false,
////             type = 
////            });
////        }
////    }
////}