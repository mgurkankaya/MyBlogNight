using Microsoft.AspNetCore.Mvc;

namespace MyBlogNight.PresentationLayer.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
