using EShop_Gp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EShop_Gp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Admin> Admin { get; set; }

        public DbSet<Cart> Cart { get; set; }
        public DbSet<UserData> UserData { get; set; }
        public DbSet<UserPayment> UserPayment { get; set; }
    }
}
