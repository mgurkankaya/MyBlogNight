using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;

namespace MyBlogNight.PresentationLayer.ViewComponents.UILayout
{
    public class _DefaultLayoutSocialMedia(ISocialMediaService _socialMediaService) : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var value = _socialMediaService.TGetAll();
            return View(value);
        }
    }
}