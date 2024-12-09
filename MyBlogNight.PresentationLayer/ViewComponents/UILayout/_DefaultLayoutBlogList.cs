using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;
using X.PagedList;
using X.PagedList.Extensions;

namespace MyBlogNight.PresentationLayer.ViewComponents.UILayout
{
    public class _DefaultLayoutBlogList(IArticleService _articleService) : ViewComponent
    {
        public IViewComponentResult Invoke(int page = 1)
        {
            // 3 öğe ve belirtilen sayfa için verileri getir
            var articles = _articleService.TArticleListWidthCategoryAndAppUser().ToPagedList(page, 3);

            return View(articles);
        }
    }
}
