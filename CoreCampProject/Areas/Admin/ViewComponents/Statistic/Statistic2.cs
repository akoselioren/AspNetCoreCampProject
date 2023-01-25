using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreCampProject.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic2: ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
              ViewBag.v1 = c.Blogs.OrderByDescending(x => x.BlogID).Select(x=>x.BlogTitle).Take(1).FirstOrDefault();
            var blogid = c.Blogs.OrderByDescending(x => x.BlogID).Select(x => x.WriterID).Take(1).FirstOrDefault();
            ViewBag.v2 = c.Writers.Where(x => x.WriterID == blogid).Select(x => x.WriterName).FirstOrDefault();
            //ViewBag.v3 = c.Comments.Count();
            return View();
        }
    }
}
