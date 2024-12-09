using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;

namespace MyBlogNight.PresentationLayer.ViewComponents.UILayout
{
    public class _DefaultLayoutSidebar(ICategoryService _categoryService, IArticleService _articleService) : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var value = _categoryService.TGetAll();
          


            return View(value);
        }
    }
}