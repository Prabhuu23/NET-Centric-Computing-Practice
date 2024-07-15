using Microsoft.AspNetCore.Mvc;

namespace urlattributeRouting.Controllers
{
    
    public class EmployeeDetailsController : Controller
    {
        [Route("Employee")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [Route("Details/{id:int?}")]
        public IActionResult GetDetails(int Id)
        {
            return View();
        }
        [Route("~/EmployeeDetails/All")]
        public IActionResult GetEmployees()
        {
            return View();
        }

    }
}
