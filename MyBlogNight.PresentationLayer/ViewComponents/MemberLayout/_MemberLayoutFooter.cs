﻿using Microsoft.AspNetCore.Mvc;

namespace MyBlogNight.PresentationLayer.ViewComponents.MemberLayout
{
    public class _MemberLayoutFooter : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}