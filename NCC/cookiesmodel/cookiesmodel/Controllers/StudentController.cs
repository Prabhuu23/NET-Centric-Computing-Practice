using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace cookiesmodel.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            // Read cookie from Request object
            string userName = Request.Cookies["UserName"];
            return View("Index", userName);
        }

        [HttpPost]
        public IActionResult Index(string userName)
        {
            // Set the key value in Cookie
            CookieOptions option = new CookieOptions();
            option.Expires = DateTime.Now.AddMinutes(10);
            Response.Cookies.Append("UserName", userName, option);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult RemoveCookie()
        {
            // Delete the cookie
            Response.Cookies.Delete("UserName");
            return RedirectToAction(nameof(Index));
        }
    }
}
