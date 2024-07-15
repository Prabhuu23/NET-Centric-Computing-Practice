using HiddenFielddemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace HiddenFielddemo.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult SetHiddenFieldValue()
        {
            User newUser = new User()
            {
                Id = 101,
                Name = "John",
                Age = 31
            };
            return View(newUser);
        }

        [HttpPost]
        public IActionResult SetHiddenFieldValuePost(User us)
        {
            var id = us.Id;  //save value and check value in compile time
            ViewBag.ID = id; //save value and check value in runtime
            return View(us);
        }
    }
}
