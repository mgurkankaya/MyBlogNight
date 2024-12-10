using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;

namespace MyBlogNight.PresentationLayer.ViewComponents.UILayout
{
    public class _DefaultFeature(IArticleService _articleService) : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var value = _articleService.TGetLastArticlesForFeature();
            return View(value);
        }
    }
}
