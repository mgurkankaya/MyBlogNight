using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;

namespace MyBlogNight.PresentationLayer.ViewComponents.UILayout
{
    public class _DefaultLayoutRecentPostFooter : ViewComponent
    {
        private readonly IArticleService _articleService;

        public _DefaultLayoutRecentPostFooter(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke()
        {
            // Son 3 makaleyi tarihe göre sıralayarak al
            var recentPosts = _articleService.TGetLastArticles();
            return View(recentPosts);
        }
    }
}
