using Microsoft.AspNetCore.Mvc;

namespace MyBlogNight.PresentationLayer.ViewComponents.UILayout
{
    public class _DefaultLayoutFooter : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
