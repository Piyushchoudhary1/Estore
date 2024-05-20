using EStore.Web.DTO;
using Microsoft.AspNetCore.Mvc;

public class OrderController : Controller
{
    // Dummy data for demonstration purposes
 

    public ActionResult Index()
    {
           var dummyOrderItems = new List<OrderDTO>
    {
        new OrderDTO { Id = 1, ProductName = "Product 1", Price = 10.99m, Quantity = 2 },
        new OrderDTO { Id = 2, ProductName = "Product 2", Price = 15.99m, Quantity = 1 },
        new OrderDTO { Id = 3, ProductName = "Product 3", Price = 20.49m, Quantity = 3 }
    };
        return View(dummyOrderItems);
    }
}

