using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreCampProject.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm= new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values =bm.GetAllCategories();
            return View(values);
        }
    }
}
