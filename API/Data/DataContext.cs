using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser { Id = 1, UserName = "Darth Vader" },
                new AppUser { Id = 2, UserName = "Luke Skywalker" },
                new AppUser { Id = 3, UserName = "Obi-Wan Kenobi" }
            );
        }
    }
}
