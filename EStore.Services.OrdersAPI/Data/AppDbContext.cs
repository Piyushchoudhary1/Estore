using EStore.Services.OrdersAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EStore.Services.OrdersAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
     
    }
}
