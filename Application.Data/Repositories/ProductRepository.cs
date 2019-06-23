namespace Application.Data.Repositories
{
    using System.Collections.Generic;
    using Application.Data.Entities;
    using System.Linq;

    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public IEnumerable<Product> GetAll(Environment environment)
        {
            return this.Query().Where(m => m.Environment == environment).ToList();
        }

        public Product GetByIdAndEnvironment(int productId, Environment environment)
        {
            return this.Query().Where(m => m.Environment == environment && m.Id == productId).FirstOrDefault();
        }
    }
}