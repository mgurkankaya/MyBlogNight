using Microsoft.AspNetCore.Mvc;

namespace MyBlogNight.PresentationLayer.ViewComponents.UILayout
{
    public class _DefaultLayoutHead:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
