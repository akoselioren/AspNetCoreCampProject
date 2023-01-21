using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreCampProject.Controllers
{
	[AllowAnonymous]
	public class LoginController : Controller
	{
		[HttpGet]
		public IActionResult LoginIndex()
		{
			return View();
		}
		[HttpPost]
		public async  Task<IActionResult> LoginIndex(Writer p)
		{

			Context c=new Context();
			var datavalues = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);
			if (datavalues != null)
			{
				var claims = new List<Claim>
				{
					new Claim(ClaimTypes.Name,p.WriterMail)
				};
				var useridentity=new ClaimsIdentity(claims,"a");
				ClaimsPrincipal principal=new ClaimsPrincipal(useridentity);
				await HttpContext.SignInAsync(principal);
				return RedirectToAction("WriterIndex", "Writer");
			}
			else
			{
				return View();
			}

		}
	}
}
//Context c = new Context();
//var datavalues = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);
//if (datavalues != null)
//{
//	HttpContext.Session.SetString("userName", p.WriterMail);
//	return RedirectToAction("WriterIndex", "Writer");
//}
//else
//{
//	return View();
//}