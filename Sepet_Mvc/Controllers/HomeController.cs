using Microsoft.AspNetCore.Mvc;
using Sepet_Mvc.Models;
using Sepet_Mvc.Models.Northwind;
using Sepet_Mvc.Models.ViewModels;
using System.Diagnostics;

namespace Sepet_Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NorthwindContext _northwindContext;

        public HomeController(ILogger<HomeController> logger,NorthwindContext context)
        {
            _logger = logger;
            _northwindContext=context;
        }

        public IActionResult Index()
        { //ürünler burada listelenecek
            
            var products=_northwindContext.Products.Select(x=>new ProductViewModel
            {
                Id=x.ProductId,
                ProductName=x.ProductName,
                UnitPrice=x.UnitPrice,
                UnitsInStock=x.UnitsInStock,
                CategoryName=x.Category.CategoryName
            }).ToList();
            return View(products);
        }

        //Products Details Action--ürün detay
        //AddToCart--sepete ekleme
        //MyCart--sepetimi görütülemek için
        public IActionResult MyCart()
        {
            return View();
        }
        
        public IActionResult Register() 
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }




















        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
