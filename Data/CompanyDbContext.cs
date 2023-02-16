using Microsoft.EntityFrameworkCore;

namespace RestaurantSystem.Company.Api.Data
{
    public class CompanyDbContext : DbContext
    {
        public DbSet<RestaurantSystem.Company.Api.Entities.Company> Companies { get; set; }
        public DbSet<RestaurantSystem.Company.Api.Entities.Country> Countries { get; set; }
        public DbSet<RestaurantSystem.Company.Api.Entities.City> Cities { get; set; }
        public DbSet<RestaurantSystem.Company.Api.Entities.Location> Locations { get; set; }
        public DbSet<RestaurantSystem.Company.Api.Entities.Currency> Currencies { get; set; }

        public CompanyDbContext(DbContextOptions<CompanyDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("companies");
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
