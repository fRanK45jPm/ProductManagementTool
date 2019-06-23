namespace Application.Data
{
    using Application.Data.Repositories;
    using Unity;

    public static class UnityConfiguration
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IProductDisplayNameRepository, ProductDisplayNameRepository>();
            container.RegisterType<IUserRepository, UserRepository>();
        }
    }
}
