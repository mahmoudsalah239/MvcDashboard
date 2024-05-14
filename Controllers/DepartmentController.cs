using Microsoft.AspNetCore.Mvc;

namespace TranningCenter.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
