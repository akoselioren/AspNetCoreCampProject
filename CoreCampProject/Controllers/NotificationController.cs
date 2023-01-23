using Microsoft.AspNetCore.Mvc;

namespace CoreCampProject.Controllers
{
    public class NotificationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
