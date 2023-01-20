using CoreCampProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreCampProject.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID= 1,
                    UserName="Abdullah"
                },
                new UserComment
                {
                    ID= 2,
                    UserName="Berkay"
                },
                new UserComment
                {
                    ID= 3,
                    UserName="Burak"
                }
            };
            return View(commentvalues);
        }
    }
}
