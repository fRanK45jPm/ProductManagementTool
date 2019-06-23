namespace Application.Data.Repositories
{
    using System.Collections.Generic;
    using Application.Data.Entities;

    public interface IProductDisplayNameRepository: IBaseRepository<ProductDisplayName>
    {
        IEnumerable<ProductDisplayName> GetProductDisplayNameByProductId(int productId);

        ProductDisplayName GetByProductIdAndLanguage(int productId, SupportLanguage language);

        void DeleteByProductId(int productId);
    }
}