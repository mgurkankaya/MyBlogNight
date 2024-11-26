using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;

namespace MyBlogNight.PresentationLayer.ViewComponents.UILayout
{
    public class _DefaultLayoutBlogList(IArticleService _articleService) : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
           var value= _articleService.TArticleListWidthCategoryAndAppUser();
            return View(value);
        }
    }
}
