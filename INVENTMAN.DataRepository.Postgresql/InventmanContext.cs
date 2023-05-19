using INVENTMAN.Entities;
using Microsoft.EntityFrameworkCore;

namespace INVENTMAN.DataRepository.Postgresql
{
    public class InventmanContext : DbContext
    {
        public DbSet<Item> items;
    }
}
