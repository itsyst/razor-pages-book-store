using Domain;
using Microsoft.EntityFrameworkCore;
 

namespace Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureCategory(modelBuilder);

            SeedDatabase(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private static void ConfigureCategory(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Category>().Property(x => x.Name).HasMaxLength(55);
        }

        private static void SeedDatabase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Romance", Order = 1},
                new Category { Id = 2, Name = "Horror", Order = 2},
                new Category { Id = 3, Name = "Finance", Order = 2 },
                new Category { Id = 4, Name = "Biography", Order = 3 }
           );
        }
    }
}
