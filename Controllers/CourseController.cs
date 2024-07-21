using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return Redirect("/course/list");
            }

            var course = Repository.getById(id);
			return View(course);
        }
        // course/list
        public IActionResult List()
        {
            
            return View(Repository.Courses);
        }
    }
}
