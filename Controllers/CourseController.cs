using Microsoft.AspNetCore.Mvc;
using TranningCenter.interfaces;
using TranningCenter.Models;

namespace TranningCenter.Controllers
{
    public class CourseController : Controller
    {
        IcourseRepositery courseRepo;
        public CourseController(IcourseRepositery _courseRepo)
        {
            courseRepo = _courseRepo;
        }

        public IActionResult Index()
        {
            List<Course> courses = courseRepo.GetAll();
            return View(courses);
        }
    }
}
