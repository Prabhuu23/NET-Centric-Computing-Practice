using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using urlattributeRouting.Areas.Sales.Models;

namespace urlattributeRouting.Areas.Sales.Controllers
{
    [Area("Sales")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Product> list = new List<Product>() {
                new Product { Name = "Pants", Quantity = 5, Price = 100 },
                new Product { Name = "Shirts", Quantity = 10, Price = 80 },
                new Product { Name = "Shoes", Quantity = 15, Price = 50 }
            };
            return View(list);
        }
    }
}
