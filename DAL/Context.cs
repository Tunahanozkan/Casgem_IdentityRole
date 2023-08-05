using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Casgem_IdentityRole.DAL
{
    public class Context:IdentityDbContext<AppUser,AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-GQ26LQR\\SQLEXPRESS;database= CasgemDbRole;integrated security = true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
