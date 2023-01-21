using Microsoft.AspNetCore.Mvc;

namespace CoreCampProject.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error1(int code)
        {
            return View();
        }
    }
}
