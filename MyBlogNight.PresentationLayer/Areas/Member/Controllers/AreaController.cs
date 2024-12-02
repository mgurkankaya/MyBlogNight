using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.PresentationLayer.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class AreaController(IArticleService _articleService, UserManager<AppUser> _userManager) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var userValue = await _userManager.FindByNameAsync(User.Identity.Name);
            var value = _articleService.TGetArticlesByAppUserId(userValue.Id);
            return View(value);
        }
    }
}