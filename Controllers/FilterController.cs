using Microsoft.AspNetCore.Mvc;
using TranningCenter.Fillters;

namespace TranningCenter.Controllers
{
    public class FilterController : Controller
    {
        [HandleError]
        public IActionResult Index()
        {
            throw new Exception();
        }
    }
}
