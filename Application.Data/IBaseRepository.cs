namespace Application.Data
{
    using System.Linq;
    using Application.Data.Entities;

    public interface IBaseRepository<T> where T : BaseEntity
    {
        T GetById(int id);

        int DeleteById(int id);

        T Create();

        IQueryable<T> Query();
    }
}