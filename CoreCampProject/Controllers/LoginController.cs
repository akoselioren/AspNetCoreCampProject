using Microsoft.AspNetCore.Mvc;

namespace CoreCampProject.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult LoginIndex()
		{
			return View();
		}
	}
}
