using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.PresentationLayer.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("[area]/[controller]/[action]")]
    public class DashboardController(IArticleService _articleService, ICommentService _commentService,UserManager<AppUser> _userManager) : Controller
    {
     

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            // Yazara ait yorum sayısı
            var commentCount = _commentService.TGetCommentsByAuthorId(user.Id);

            //// Yazara ait toplam makale sayısı
            var articleCount = _articleService.TGetArticlesByAppUserId(user.Id).Count();

            //// Yazara ait makalelerden en yüksek görüntülenme sayısı
            var topViewedArticle = _articleService.TGetArticlesByAppUserId(user.Id)
                                                   .OrderByDescending(x => x.ArticleViewCount)
                                                   .FirstOrDefault();

            if (topViewedArticle != null)
            {
                ViewBag.MaxViewCount = topViewedArticle.ArticleViewCount;
                ViewBag.TopViewedArticleTitle = topViewedArticle.Title;
            }
            else
            {
                ViewBag.MaxViewCount = 0;
                ViewBag.TopViewedArticleTitle = "Henüz bir yazınız bulunmuyor.";
            }

            ViewBag.CommentCount = commentCount;
            ViewBag.ArticleCount = articleCount;

            return View();
        }
    }

}
