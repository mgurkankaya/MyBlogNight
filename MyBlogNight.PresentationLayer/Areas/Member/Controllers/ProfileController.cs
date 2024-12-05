using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using MyBlogNight.EntityLayer.Concrete;
using MyBlogNight.PresentationLayer.Areas.Member.Models;
using Microsoft.IdentityModel.Tokens;
using System.Linq;

namespace MyBlogNight.PresentationLayer.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class ProfileController(UserManager<AppUser> _userManager) : Controller
    {
        public async Task<IActionResult> EditMyProfile()
        {
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel model = new UserEditViewModel();
            model.Name = value.Name;
            model.Surname = value.Surname;
            model.Username = value.UserName;
            model.Email = value.Email;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EditMyProfile(UserEditViewModel model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
           

            user.Name = model.Name;
            user.Surname = model.Surname;
            user.UserName = model.Username;
            user.Email = model.Email;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.Password);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login", new { area = "" });

            }

            return View();
        }
    }
}
