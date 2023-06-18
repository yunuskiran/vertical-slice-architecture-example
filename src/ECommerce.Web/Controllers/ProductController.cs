using ECommerce.Core.Features.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Web.Controllers;

public class ProductController : Controller
{
    private readonly IProductService productService;

    public ProductController(IProductService productService)
    {
        this.productService = productService;
    }

    public IActionResult Index()
    {
        var products = productService.GetProducts();
        return View(products);
    }
}
