using EStore.Web.DTO;
using Microsoft.AspNetCore.Mvc;

public class CartController : Controller
{
    // Dummy data for demonstration purposes


    // GET: ShoppingCart
    public ActionResult Index()
    {
           var dummyItems = new List<CartDTO>
    {


        new CartDTO { Id = 1, Name = "Product 1", Price = 10.99m, Quantity = 1 },
        new CartDTO { Id = 2, Name = "Product 2", Price = 15.99m, Quantity = 2 },
        new CartDTO { Id = 3, Name = "Product 3", Price = 20.49m, Quantity = 1 }
    };

        return View("CartView",dummyItems);
    }

    // Add item to cart
    [HttpGet]
    public ActionResult AddToCart(int itemId)
    {
        // Add logic to add item to the shopping cart
        // For simplicity, let's just return to the index page
        return RedirectToAction("Index");
    }

    // Remove item from cart
    [HttpPost]
    public ActionResult RemoveFromCart(int itemId)
    {
        // Add logic to remove item from the shopping cart
        // For simplicity, let's just return to the index page
        return RedirectToAction("Index");
    }
}

