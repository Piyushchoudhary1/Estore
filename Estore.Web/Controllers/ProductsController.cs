using AspNetCore;
using EStore_frontend.DTO;
using Microsoft.AspNetCore.Mvc;

namespace EStore_frontend.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
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
