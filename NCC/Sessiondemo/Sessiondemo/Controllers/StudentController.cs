using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Sessiondemo.Models;

namespace Sessiondemo.Controllers
{
    public class StudentController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public StudentController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            
            HttpContext.Session.SetString("Name", "Pratik Khadka");
            HttpContext.Session.SetInt32("Age", 23);

            User newUser = new User()
            {
                Name = HttpContext.Session.GetString("Name"),
                Age = HttpContext.Session.GetInt32("Age").Value
            };

            // Pass the newUser object to the view
            return View(newUser);
        }
    }
}
