using Microsoft.AspNetCore.Mvc;

namespace MyBlogNight.PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
