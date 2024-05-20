using Estore.Web.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Estore.Web.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult AllProducts()
        {

            var dummyProducts = new List<ProductDTO>
            {
             new ProductDTO {Id = 1, Name = "Product 1", Description = "Description 1", Price = 199},
             new ProductDTO {Id = 2, Name = "Product 2", Description = "Description 2", Price = 149},
             new ProductDTO {Id = 3, Name = "Product 3", Description = "Description 3", Price = 299},
            };
            return View(dummyProducts);
        }
    }
}
