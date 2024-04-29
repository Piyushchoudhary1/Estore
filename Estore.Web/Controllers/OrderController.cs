using System.EStore.Web;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

public class OrderController : Controller
{
    // Dummy data for demonstration purposes
    private List<OrderItem> dummyOrderItems = new List<OrderItem>
    {
        new OrderItem { Id = 1, ProductName = "Product 1", Price = 10.99m, Quantity = 2 },
        new OrderItem { Id = 2, ProductName = "Product 2", Price = 15.99m, Quantity = 1 },
        new OrderItem { Id = 3, ProductName = "Product 3", Price = 20.49m, Quantity = 3 }
    };

    // GET: Order
    public ActionResult Index()
    {
        return View(dummyOrderItems);
    }
}

