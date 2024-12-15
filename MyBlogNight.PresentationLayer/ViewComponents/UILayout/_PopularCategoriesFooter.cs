using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;

namespace MyBlogNight.PresentationLayer.ViewComponents.UILayout
{
    public class _PopularCategoriesFooter : ViewComponent
    {
        private readonly IArticleService _articleService;

        public _PopularCategoriesFooter(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke()
        {
            var popularCategories = _articleService.TGetArticleCountByCategory();
            return View(popularCategories);
        }
    }
}
