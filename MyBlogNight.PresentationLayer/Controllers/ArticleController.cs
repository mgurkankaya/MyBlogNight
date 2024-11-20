using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;

namespace MyBlogNight.PresentationLayer.Controllers
{
    public class ArticleController(IArticleService _articleService) : Controller
    {
        public IActionResult ArticleList()
        {
            var value=_articleService.TArticleListWithCategory();
            return View(value);
        }
    }
}
