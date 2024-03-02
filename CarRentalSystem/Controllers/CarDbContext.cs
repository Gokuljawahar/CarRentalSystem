using Microsoft.EntityFrameworkCore;

namespace CarRentalSystem.Models
{
    public class CarDbContext : DbContext
    {
        public DbSet<CarModel> Cars { get; set; }

        public CarDbContext(DbContextOptions<CarDbContext> options) : base(options)
        {
        }
    }
}
