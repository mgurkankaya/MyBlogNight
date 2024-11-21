using Microsoft.AspNetCore.Mvc;

namespace MyBlogNight.PresentationLayer.ViewComponents.UILayout
{
    public class _DefaultLayoutNavbar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}