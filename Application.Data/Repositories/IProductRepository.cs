namespace Application.Data.Repositories
{
    using System.Collections.Generic;
    using Application.Data.Entities;

    public interface IProductRepository: IBaseRepository<Product>
    {
        IEnumerable<Product> GetAll(Environment environment);

        Product GetByIdAndEnvironment(int productId, Environment environment);
    }
}
