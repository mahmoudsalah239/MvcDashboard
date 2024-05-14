using Microsoft.AspNetCore.Mvc;
using TranningCenter.interfaces;
using TranningCenter.Models;

namespace TranningCenter.Controllers
{
    public class InstructorController : Controller
    {
        IinstructorRepositery iinstructorRepos;
        public InstructorController(IinstructorRepositery insRepo)
        {
            iinstructorRepos = insRepo;


        }
        public IActionResult Index()
        {

            List<Instructor> instructors = iinstructorRepos.GetAll();

            return View(instructors);
        }
        [HttpGet]
        public IActionResult Create()
        {
            List<Instructor> ins = iinstructorRepos.GetAll();
            ViewBag.course = ins;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Instructor ins)
        {
            iinstructorRepos.insert(ins);
            iinstructorRepos.save();
            return RedirectToAction("Index");

        }
    }
}
