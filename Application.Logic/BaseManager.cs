namespace Application.Logic
{
    using Application.Data;
    using Unity;

    public class BaseManager
    {
        [Dependency]
        public IBaseDbContextAccessor BaseDbContextAccessor { get; set; }

        public int Save()
        {
            return this.BaseDbContextAccessor.SaveChanges();
        }
    }
}
