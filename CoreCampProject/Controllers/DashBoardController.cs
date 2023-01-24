using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreCampProject.Controllers
{
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            Context c = new Context();
            ViewBag.value1 = c.Blogs.Count().ToString();
            ViewBag.value2 = c.Blogs.Where(x => x.WriterID == 1).Count().ToString();
            ViewBag.value3 = c.Categories.Count().ToString();
            return View();
        }
    }
}
