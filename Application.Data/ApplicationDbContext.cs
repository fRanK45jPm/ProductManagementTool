namespace Application.Data
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using Application.Data.Entities;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("ApplicationDatabase")
        {
        }

        public DbSet<Product> Product { get; set; }

        public DbSet<ProductDisplayName> ProductDetail { get; set; }

        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
