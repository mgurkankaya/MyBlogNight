using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.PresentationLayer.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class ArticleController(IArticleService _articleService, UserManager<AppUser> _userManager, ICategoryService _categoryService) : Controller
    {
        public async Task<IActionResult> ArticleList()
        {
            var userValue = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewData["UserFullName"] = $"{userValue.Name} {userValue.Surname}";
            var value = _articleService.TGetArticlesByAppUserId(userValue.Id);
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
        public async Task<IActionResult> CreateArticle(Article article)
        {
            var userValue = await _userManager.FindByNameAsync(User.Identity.Name);
            article.AppUserId = userValue.Id; // Kullanıcının Id'sini makale ile ilişkilendiriyoruz.
            article.CreatedDate = DateTime.Now;
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
            var value = _articleService.TGetById(article.ArticleId);

            if (value == null)
            {
                return NotFound("Makale bulunamadı.");
            }

            // Mevcut alanları koruyarak sadece gerekli alanları güncelle
            value.Title = article.Title;
            value.Detail = article.Detail;
            value.CategoryId = article.CategoryId;
            value.MainImageUrl = article.MainImageUrl;

            _articleService.TUpdate(value);
            return RedirectToAction("ArticleList");
        }


    }
}