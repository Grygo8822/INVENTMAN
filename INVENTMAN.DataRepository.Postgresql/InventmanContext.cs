using INVENTMAN.Entities;
using Microsoft.EntityFrameworkCore;

namespace INVENTMAN.DataRepository.Postgresql
{
    public class InventmanContext : DbContext
    {
        public InventmanContext(DbContextOptions<InventmanContext> options) :base(options)
        {

        }

        public DbSet<Item> Items { get; set; } = null!;
        public DbSet<Event> Events { get; set; } = null!;
        public DbSet<Manufacturer> Manufacturers { get; set; } = null!;
        public DbSet<Vendor> Vendors { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Onboarding> Onboardings { get; set; } = null!;


    }
}
