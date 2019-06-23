namespace Application.Data
{
    using Application.Data.Entities;
    using System.Linq;
    using Unity;

    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        [Dependency]
        public IBaseDbContextAccessor BaseDbContextAccessor { get; set; }

        public T GetById(int id)
        {
            return this.BaseDbContextAccessor.Context().Set<T>().FirstOrDefault(m => m.Id == id);
        }

        public T Create()
        {
            var instance = this.BaseDbContextAccessor.Context().Set<T>().Create();
            this.BaseDbContextAccessor.Context().Set<T>().Add(instance);

            return instance;
        }

        public int DeleteById(int id)
        {
            var entity = this.GetById(id);
            this.BaseDbContextAccessor.Context().Set<T>().Remove(entity);

            return this.Save();
        }

        public int Save()
        {
            return this.BaseDbContextAccessor.Context().SaveChanges();
        }

        public IQueryable<T> Query()
        {
            return this.BaseDbContextAccessor.Context().Set<T>().AsQueryable();
        }
    }
}
