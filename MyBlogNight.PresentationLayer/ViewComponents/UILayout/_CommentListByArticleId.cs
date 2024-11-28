using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;

namespace MyBlogNight.PresentationLayer.ViewComponents.UILayout
{
    public class _CommentListByArticleId(ICommentService _commentService):ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var value = _commentService.TGetCommentsByArticleId(3);
            return View(value);
        }


    }
}