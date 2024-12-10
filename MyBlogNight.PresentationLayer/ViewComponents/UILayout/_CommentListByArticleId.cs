using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.PresentationLayer.ViewComponents.UILayout
{

    public class _CommentListByArticleId(ICommentService _commentService, UserManager<AppUser> _userManager) :ViewComponent
    {
  
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Kullanıcı giriş yapmış mı kontrol et
            if (User.Identity?.Name == null)
            {
                // Giriş yapılmamış, uyarı mesajını göstermek için bir flag (işaret) döndür
                ViewBag.IsLoggedIn = false;
                return View(new List<Comment>());
            }

            // Giriş yapan kullanıcının bilgilerini al
            var userValue = await _userManager.FindByNameAsync(User.Identity.Name);

            if (userValue == null)
            {
                // Kullanıcı bulunamazsa boş bir liste döndür
                ViewBag.IsLoggedIn = false;
                return View(new List<Comment>());
            }

            // Kullanıcı ID'sine göre yorumları getir
            var value = _commentService.TGetCommentsByAppUserId(userValue.Id);

            ViewBag.IsLoggedIn = true;
            return View(value);
        }
    }


    }