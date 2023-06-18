using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Web.Controllers;

public class CartController : Controller
{
    private readonly ICartService cartService;

    public CartController(ICartService cartService)
    {
        this.cartService = cartService;
    }

    public IActionResult Index()
    {
        var cartItems = cartService.GetCartItems();
        return View(cartItems);
    }

    public IActionResult AddToCart(int productId)
    {
        cartService.AddToCart(productId);
        return RedirectToAction("Index");
    }

    public IActionResult RemoveFromCart(int productId)
    {
        cartService.RemoveFromCart(productId);
        return RedirectToAction("Index");
    }
}
