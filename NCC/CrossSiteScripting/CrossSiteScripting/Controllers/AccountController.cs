using Microsoft.AspNetCore.Mvc;

namespace CrossSiteScripting.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AccountController obj )
        {
            return View();
        }
    }
}
