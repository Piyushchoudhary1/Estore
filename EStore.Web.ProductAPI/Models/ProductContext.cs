using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
// using System.Data.Entity;

namespace EStore.Web.ProductAPI.Models
{
    public class ProductContext : DbContext
    {
        

        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

    }

}
