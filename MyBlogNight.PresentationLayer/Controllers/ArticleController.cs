using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;

namespace MyBlogNight.PresentationLayer.Controllers
{
    public class ArticleController(IArticleService _articleService) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ArticleDetail(int id)
        {
            _articleService.ArticleViewCountIncrease(id);
            var value = _articleService.TArticleListWithCategoryAndAppUserByArticleId(id);
            return View(value);
        }
    }
}
