using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.EntityLayer.Concrete;
using MyBlogNight.PresentationLayer.Models;

namespace MyBlogNight.PresentationLayer.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IArticleService _articleService;

        public CommentController(IArticleService articleService, UserManager<AppUser> userManager, ICommentService commentService)
        {
            _articleService = articleService;
            _userManager = userManager;
            _commentService = commentService;
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(int articleId, string commentContent)
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = await _userManager.GetUserAsync(User);

                if (user == null)
                {
                    return RedirectToAction("Login", "Account");
                }

                // Yeni yorum oluştur
                var newComment = new Comment
                {
                    AppUserId = user.Id, // Giriş yapan kullanıcının ID'si
                    Name = $"{user.Name} {user.Surname}", // Kullanıcının adı ve soyadı
                    Email = user.Email, // Kullanıcının e-posta adresi
                    CommentDetail = commentContent, // Yorum içeriği
                    ArticleId = articleId, // Makale ID'si
                    CreatedDate = DateTime.Now, // Yorum tarihi
                    Status = true // Varsayılan olarak aktif
                };

                _commentService.TInsert(newComment);

                return RedirectToAction("ArticleDetail", "Article", new { id = articleId });
            }

            return RedirectToAction("Login", "Account");
        }



    }
}