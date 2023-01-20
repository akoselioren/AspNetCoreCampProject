

using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace CoreCampProject.ViewComponents.Category
{
    public class CategoryList:ViewComponent
    {
        CategoryManager cm=new CategoryManager(new EfCategoryRepository());

        public IViewComponentResult Invoke()
        {
            var values=cm.GetAllCategories();
            return View(values);
        }
    }
}
