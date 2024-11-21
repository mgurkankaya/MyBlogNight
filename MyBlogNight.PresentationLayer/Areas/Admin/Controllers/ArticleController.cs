using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class ArticleController(IArticleService _articleService, ICategoryService _categoryService) : Controller
    {
        public IActionResult ArticleList()
        {
            var value = _articleService.TArticleListWithCategory();
            return View(value);
        }

        [HttpGet]
        public IActionResult CreateArticle()
        {
            var categoryList = _categoryService.TGetAll();
            List<SelectListItem> values1 = (from x in categoryList
                                            select new SelectListItem
                                            {
                                                Text = x.CategoryName,
                                                Value = x.CategoryId.ToString()
                                            }).ToList();
            ViewBag.v1 = values1;
            return View();
        }

        [HttpPost]
        public IActionResult CreateArticle(Article article)
        {
            _articleService.TInsert(article);
            return RedirectToAction("ArticleList");
        }

        public IActionResult DeleteArticle(int id)
        {
            _articleService.TDelete(id);
            return RedirectToAction("ArticleList");
        }


        [HttpGet]
        public IActionResult UpdateArticle(int id)
        {
            var categoryList = _categoryService.TGetAll();
            var value = _articleService.TGetById(id);
            
            List<SelectListItem> values1 = (from x in categoryList
                                            select new SelectListItem
                                            {
                                                Text = x.CategoryName,
                                                Value = x.CategoryId.ToString()
                                            }).ToList();
            ViewBag.v1 = values1;
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateArticle(Article article)
        {
            
            _articleService.TUpdate(article);
            return RedirectToAction("ArticleList");
        }
    }
}
