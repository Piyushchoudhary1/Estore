using System.EStore.Web;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

public class ShoppingCartController : Controller
{
    // Dummy data for demonstration purposes
    private List<ShoppingCartItem> dummyItems = new List<ShoppingCartItem>
    {
        new ShoppingCartItem { Id = 1, Name = "Product 1", Price = 10.99m, Quantity = 1 },
        new ShoppingCartItem { Id = 2, Name = "Product 2", Price = 15.99m, Quantity = 2 },
        new ShoppingCartItem { Id = 3, Name = "Product 3", Price = 20.49m, Quantity = 1 }
    };

    // GET: ShoppingCart
    public ActionResult Index()
    {
        return View(dummyItems);
    }

    // Add item to cart
    [HttpPost]
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

