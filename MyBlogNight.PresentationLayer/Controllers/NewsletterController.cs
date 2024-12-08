using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.PresentationLayer.Controllers
{
    public class NewsletterController : Controller
    {
        private readonly INewsletterService _newsletterService;

        public NewsletterController(INewsletterService newsletterService)
        {
            _newsletterService = newsletterService;
        }

        [HttpPost]
        public IActionResult Subscribe(Newsletter newsletter)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _newsletterService.TInsert(newsletter); // Veri tabanına ekleme
                    return Json(new { success = true, message = "Eklendi!" });
                }
                else
                {
                    return Json(new { success = false, message = "Geçersiz veri!" });
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = $"Hata: {ex.Message}" });
            }
        }
    }
}
