using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;

namespace MyBlogNight.PresentationLayer.ViewComponents.UILayout
{
    public class _DefaultLayoutFooter(IArticleService _articleService) : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var value = _articleService.TGetTopArticles();
            return View(value);
        }
    }
}
