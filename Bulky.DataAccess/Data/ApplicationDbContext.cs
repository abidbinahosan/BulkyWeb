using Bulky.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Data
{
    //Basic Configuration of Entity Framework
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) // Default method in the DbContest (EF core)
        {
            modelBuilder.Entity<Category>().HasKey(c => c.Id); // Primary key

            modelBuilder.Entity<Category>().HasData( // Seed data
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Comedy", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Drama", DisplayOrder = 4 }
            );
        }
    }
}
