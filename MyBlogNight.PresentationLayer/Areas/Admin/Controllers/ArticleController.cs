using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;

namespace MyBlogNight.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class ArticleController(IArticleService _articleService) : Controller
    {
        public IActionResult ArticleList()
        {
            var value = _articleService.TArticleListWithCategory();
            return View(value);
        }
    }
}
