using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using MM.Models;

namespace MM.MMContext
{
    public class MMDbContext : DbContext
    {
        private static bool _created = false;
        public MMDbContext(DbContextOptions<MMDbContext> options) : base(options)
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureCreated();
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProducSubCategory> ProductSubCategories { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Item> Items { get; set; }

    }
}
