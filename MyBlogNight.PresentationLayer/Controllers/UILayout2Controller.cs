using Microsoft.AspNetCore.Mvc;

namespace MyBlogNight.PresentationLayer.Controllers
{
    public class UILayout2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
