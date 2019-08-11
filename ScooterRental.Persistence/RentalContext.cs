using Microsoft.EntityFrameworkCore;
using ScooterRental.Persistence.Dtos;

namespace ScooterRental.Persistence
{
    public class RentalContext : DbContext
    {
        public DbSet<UserDtoDb> Users { get; set; }
        public DbSet<ScooterDtoDb> Scooters { get; set; }
        public DbSet<RentalDtoDb> Rentals { get; set; }
        public DbSet<DefectDtoDb> Defects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("FileName = ScooterDB.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
