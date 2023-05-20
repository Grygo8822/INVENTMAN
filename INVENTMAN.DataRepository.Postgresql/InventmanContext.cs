using INVENTMAN.Entities;
using Microsoft.EntityFrameworkCore;

namespace INVENTMAN.DataRepository.Postgresql
{
    public class InventmanContext : DbContext
    {
        public InventmanContext(DbContextOptions options) :base(options)
        {

        }

        public DbSet<Item>? Items{ get; set; }
        public DbSet<Event>? Events { get; set; }
        public DbSet<Manufacturer>? Manufacturers { get; set; }
        public DbSet<Vendor>? Vendors { get; set; }
        public DbSet<Employee>? Employees { get; set; }
        public DbSet<Onboarding>? Onboardings { get; set; }


    }
}
