using Microsoft.EntityFrameworkCore;

namespace Redis.API.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {

        }

        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    Name = "kalem 1"
                },
                new Product()
                {
                    Id = 2,
                    Name = "kalem 2"
                },
                new Product()
                {
                    Id = 3,
                    Name = "kalem 3"
                });
        }
    }
}
