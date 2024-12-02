using Microsoft.AspNetCore.Mvc;

namespace MyBlogNight.PresentationLayer.Controllers
{
    public class MemberLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
