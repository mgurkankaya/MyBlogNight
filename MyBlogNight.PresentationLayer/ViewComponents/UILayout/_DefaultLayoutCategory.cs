using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;

namespace MyBlogNight.PresentationLayer.ViewComponents.UILayout
{
    public class _DefaultLayoutCategory(ICategoryService _categoryService) : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var value = _categoryService.TGetAll();
            return View(value);
        }
    }
}
