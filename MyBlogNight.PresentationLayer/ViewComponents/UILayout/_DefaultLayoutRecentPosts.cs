using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;

namespace MyBlogNight.PresentationLayer.ViewComponents.UILayout
{
    public class _DefaultLayoutRecentPosts : ViewComponent
    {
        private readonly IArticleService _articleService;

        public _DefaultLayoutRecentPosts(IArticleService articleService)
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
