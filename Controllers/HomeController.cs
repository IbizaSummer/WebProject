using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebProject.Models;

namespace WebProject.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult ShoppingCart()
    {
        return View("/Views/Shared/shoping-cart.cshtml");
    }
    
    public IActionResult Product()
    {
        return View("/Views/Shared/product.cshtml");
    }
    
    public IActionResult ProductDetail()
    {
        return View("/Views/Shared/product-detail.cshtml");
    }
    
    public IActionResult About()
    {
        return View("/Views/Shared/about.cshtml");
    }
    
    public IActionResult Contact()
    {
        return View("/Views/Shared/contact.cshtml");
    }
    
    public IActionResult Blog()
    {
        return View("/Views/Shared/blog.cshtml");
    }
    
    public IActionResult BlogDetail()
    {
        return View("/Views/Shared/blog-detail.cshtml");
    }
    
    public IActionResult Home02()
    {
        return View("/Views/Shared/home-02.cshtml");
    }
    
    public IActionResult Home03()
    {
        return View("/Views/Shared/home-03.cshtml");
    }
    
}
