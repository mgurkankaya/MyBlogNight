using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.PresentationLayer.ViewComponents.UILayout
{

    public class _CommentListByArticleId(ICommentService _commentService, UserManager<AppUser> _userManager) : ViewComponent
    {

        public IViewComponentResult Invoke(int articleId)
        {
            var comments = _commentService.TGetCommentsByArticleId(articleId);
            return View(comments);
        }
    }
}