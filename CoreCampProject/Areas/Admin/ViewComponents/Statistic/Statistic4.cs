using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreCampProject.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic4: ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
       Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Admins.Where(x => x.AdminID == 1).Select( y=> y.Name).FirstOrDefault();
            ViewBag.v2 = c.Admins.Where(x => x.AdminID == 1).Select( y=> y.ImageUrl).FirstOrDefault();
            ViewBag.v3 = c.Admins.Where(x => x.AdminID == 1).Select( y=> y.ShortDescription).FirstOrDefault();
            return View();
        }
    }
}
