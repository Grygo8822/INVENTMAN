using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace INVENTMAN.App.Data
{
    public class AccountDbContext : IdentityDbContext
    {
        public AccountDbContext(DbContextOptions<AccountDbContext> options) : base(options)
        {

        }
    }
}
