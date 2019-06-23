namespace Application.Data
{
    public class BaseDbContextAccessor : IBaseDbContextAccessor
    {
        private readonly ApplicationDbContext testApplicationDbContext;

        public BaseDbContextAccessor()
        {
            this.testApplicationDbContext = new ApplicationDbContext();
        }

        public ApplicationDbContext Context()
        {
            return this.testApplicationDbContext;
        }

        public int SaveChanges()
        {
            return this.testApplicationDbContext.SaveChanges();
        }
    }
}
