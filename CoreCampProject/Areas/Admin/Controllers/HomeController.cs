using Microsoft.AspNetCore.Mvc;

namespace CoreCampProject.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
