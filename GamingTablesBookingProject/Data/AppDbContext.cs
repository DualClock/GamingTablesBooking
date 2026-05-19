using Microsoft.EntityFrameworkCore;
using GamingTablesBookingProject.Models;

namespace GamingTablesBookingProject.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<GameTable> Tables { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Database=GamingTablesBooking;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=""GamingTablesBooking"";Command Timeout=30";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}