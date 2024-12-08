using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.PresentationLayer.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class CommentController(ICommentService _commentService, UserManager<AppUser> _userManager) : Controller
    {
        public async Task<IActionResult> MyCommentList()
        {
            var userValue = await _userManager.FindByNameAsync(User.Identity.Name);
            var userId = userValue.Id;
            var value = _commentService.TGetCommentsByAppUserId(userId);
            return View(value);
        }
    }
}