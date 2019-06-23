namespace Application.WebApi
{
    using System;
    using Application.Data;
    using Application.Logic;
    using Application.WebApi.Services;
    using Unity;
    using Unity.Lifetime;

    public static class UnityConfig
    {
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });


        public static IUnityContainer Container => container.Value;

        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IProductDisplayNameService, ProductDisplayNameService>();
            container.RegisterType<IProductService, ProductService>();
            container.RegisterType<IUserService, UserService>();
            container.RegisterType<IBaseDbContextAccessor, BaseDbContextAccessor>(new PerResolveLifetimeManager());
            container.RegisterType<IUserContext, UserContext>(new ContainerControlledLifetimeManager());

            Logic.UnityConfiguration.RegisterTypes(container);
        }
    }
}