namespace Application.Data
{
    using System.Linq;

    public interface IBaseDbContextAccessor
    {
        int SaveChanges();

        ApplicationDbContext Context();
    }
}
