using Microsoft.EntityFrameworkCore;

namespace Curso01.Data
{
    public class Curso01DbContext : DbContext
    {
        public Curso01DbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        
        protected override  void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Brasil",
                    ShortName = "BR"

                },
                new Country 
                { 
                    Id = 2, 
                    Name = "Ireland", 
                    ShortName ="IRL"
                }, 
                new Country 
                { 
                    Id= 3, 
                    Name="Italy", 
                    ShortName="ITA"
                }

            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Copacabana Palace",
                    Address = "Av. Atlantica",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel 
                { 
                    Id = 2,
                    Name = "Clayton Hotel",
                    Address = "50, Dorset Street Upper",
                    CountryId = 2,
                    Rating = 4.2
                },
                new Hotel 
                {
                    Id = 3,
                    Name = "Bella Taormina",
                    Address = "Via della Taormina, 15",
                    CountryId = 3,
                    Rating = 4.0
                }

                );

        }
        
    }
        
}
