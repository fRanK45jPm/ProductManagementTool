namespace Application.Data.Repositories
{
    using System.Collections.Generic;
    using Application.Data.Entities;
    using System.Linq;

    public class ProductDisplayNameRepository : BaseRepository<ProductDisplayName>, IProductDisplayNameRepository
    {
        public IEnumerable<ProductDisplayName> GetProductDisplayNameByProductId(int productId)
        {
            return this.Query().Where(m => m.Product.Id == productId).AsEnumerable();
        }

        public ProductDisplayName GetByProductIdAndLanguage(int productId, SupportLanguage language)
        {
            return this.Query().FirstOrDefault(m => m.Product.Id == productId && m.Language == language);
        }

        public void DeleteByProductId(int productId)
        {
            var products = this.Query().Where(m => m.Product.Id == productId).ToList();

            foreach (var item in products)
            {
                this.DeleteById(item.Id);
            }
        }
    }
}
