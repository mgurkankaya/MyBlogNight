using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.EntityLayer.Concrete;
using X.PagedList.Extensions;

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


        public IActionResult Category(int id, int page = 1)
        {
            var articles = _articleService.TGetArticlesByCategoryId(id)?.ToPagedList(page, 3);

            if (articles == null || !articles.Any())
            {
                // Boş bir IPagedList döndür
                articles = new List<Article>().ToPagedList(page, 3);
            }

            return View(articles);
        }

    }
}
