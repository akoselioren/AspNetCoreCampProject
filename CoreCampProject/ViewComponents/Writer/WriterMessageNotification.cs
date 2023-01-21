using Microsoft.AspNetCore.Mvc;

namespace CoreCampProject.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            return View();
        }
    }
}
