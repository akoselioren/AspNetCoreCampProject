using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreCampProject.Controllers
{
	public class AboutController : Controller
	{
		AboutManager abm=new AboutManager(new EfAboutRepository());
		public IActionResult AboutIndex()
		{
			var values = abm.GetList();
			return View(values);
			
		}
		public PartialViewResult SocialMediaAbout()
		{
			return PartialView();
		}
	}
}
