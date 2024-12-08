using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.PresentationLayer.ViewComponents.UILayout
{
    public class _DefaultNewsletter : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }

}
