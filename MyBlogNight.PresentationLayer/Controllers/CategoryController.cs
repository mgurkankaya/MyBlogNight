using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;

namespace MyBlogNight.PresentationLayer.Controllers
{
    public class CategoryController(ICategoryService _categoryService) : Controller
    {
        public IActionResult CategoryList()
        {
            var value = _categoryService.TGetAll();
            return View(value);
        }
    }
}