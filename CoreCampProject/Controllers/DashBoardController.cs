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
			var username = User.Identity.Name;
			var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerid=c.Writers.Where(x => x.WriterMail==usermail).Select(y=>y.WriterID).FirstOrDefault();
			ViewBag.value1 = c.Blogs.Count().ToString();
            ViewBag.value2 = c.Blogs.Where(x => x.WriterID == writerid).Count().ToString();
            ViewBag.value3 = c.Categories.Count().ToString();
            return View();
        }
    }
}
