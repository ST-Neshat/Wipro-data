using Microsoft.EntityFrameworkCore;
using MovieCatalog.Api.Models;

namespace MovieCatalog.Api.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Movie> Movies => Set<Movie>();
        public DbSet<Director> Directors => Set<Director>();

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Director>()
                .HasMany(d => d.Movies)
                .WithOne(m => m.Director!)
                .HasForeignKey(m => m.DirectorId)
                .OnDelete(DeleteBehavior.Cascade);

            // Optional seed for quick testing
            modelBuilder.Entity<Director>().HasData(
                new Director { Id = 1, Name = "Christopher Nolan", Bio = "Known for complex narratives." },
                new Director { Id = 2, Name = "Greta Gerwig", Bio = "American filmmaker and actor." }
            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Inception", ReleaseYear = 2010, DirectorId = 1 },
                new Movie { Id = 2, Title = "Oppenheimer", ReleaseYear = 2023, DirectorId = 1 },
                new Movie { Id = 3, Title = "Lady Bird", ReleaseYear = 2017, DirectorId = 2 }
            );
        }
    }
}