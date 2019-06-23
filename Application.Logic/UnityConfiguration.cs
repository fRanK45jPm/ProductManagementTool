namespace Application.Logic
{
    using Application.Logic.Managers;
    using Unity;

    public static class UnityConfiguration
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IProductManager, ProductManager>();
            container.RegisterType<IProductDisplayNameManager, ProductDisplayNameManager>();
            container.RegisterType<IUserManager, UserManager>();

            Data.UnityConfiguration.RegisterTypes(container);
        }
    }
}
