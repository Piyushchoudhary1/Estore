using Estore.ShoppingCartAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Estore.Services.ShoppingCartAPI.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<CartHeader> CartHeaders { get; set; }
        public DbSet<CartDetails> CartDetails { get; set; }

    }
}