using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;
using X.PagedList;
using X.PagedList.Extensions;

namespace MyBlogNight.PresentationLayer.ViewComponents.UILayout
{
    [Route("[Controller]/[Action]/{id?}")]
    public class _DefaultLayoutBlogList(IArticleService _articleService) : ViewComponent
    {
        public IViewComponentResult Invoke(int page = 1)
        {
            var articles = _articleService.TArticleListWidthCategoryAndAppUser().ToPagedList(page, 3);
            return View(articles);
        }


    }
}
