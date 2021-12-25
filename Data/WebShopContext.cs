
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SecureShop.Models;
using SecureShopAPI.Models;



namespace SecureShopAPI.Data
{
    public class WebShopContext: IdentityDbContext<ApplicationUser>
    {
        public WebShopContext(DbContextOptions<WebShopContext> options) : base(options) { }
        public DbSet<WebShop> WebShopes { get; set; }
       
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }


    }
}
