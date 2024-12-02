using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;

namespace MyBlogNight.PresentationLayer.ViewComponents.UILayout
{
    public class _BlogDetailSideBar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
           
            return View();
        }
    }
}