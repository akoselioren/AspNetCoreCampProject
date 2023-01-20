using BusinessLayer.Concrete;
using CoreCampProject.Models;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreCampProject.ViewComponents.Comment
{
    public class CommentListByBlog:ViewComponent
    {
        CommentManager cm =new CommentManager(new EfCommentRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = cm.GetList(id);
            return View(values);
        }
    }
}
