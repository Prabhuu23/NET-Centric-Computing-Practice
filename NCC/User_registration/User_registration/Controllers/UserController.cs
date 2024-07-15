using Microsoft.AspNetCore.Mvc;
using System.Reflection;
namespace User_registration.Controllers
{
    public class UserController : Controller

    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Models.User user)
        {
            if (ModelState.IsValid)
            {
                // Save user to database or perform other actions
                return RedirectToAction("Display", user);
            }
            return View("Index", user);
        }
        public IActionResult Display(Models.User user)
        {
            return View(user);
        }
    }
}