using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebProject.Models;
using System.Threading.Tasks;

namespace WebProject.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IEmailSender _emailSender;

    public HomeController(ILogger<HomeController> logger, IEmailSender emailSender)
    {
        _logger = logger;
        _emailSender = emailSender;
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

    [HttpPost]
    public async Task<IActionResult> Subscribe(string email)
    {
        if (string.IsNullOrEmpty(email))
        {
            return BadRequest("Email is required.");
        }

        var subject = "Thank you for subscribing!";
        var message = "<p>Dear user,</p><p>Thank you for subscribing to our newsletter!</p>";
        await _emailSender.SendEmailAsync(email, subject, message);

        return Ok("Subscription successful.");
    }
}
