using Microsoft.AspNetCore.Mvc;

namespace CoreCampProject.Areas.Admin.Controllers
{
    public class WidgetController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }

    }
}
