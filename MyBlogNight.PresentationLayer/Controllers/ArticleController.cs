using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.EntityLayer.Concrete;

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

       
        public IActionResult Category(int id)
        {
            var articles = _articleService.TGetArticlesByCategoryId(id);

            if (articles == null || !articles.Any())
            {
                return View(new List<Article>());
            }

            return View(articles);
        }
    }
}
