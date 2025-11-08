using Microsoft.AspNetCore.Mvc;

namespace HRMS.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
