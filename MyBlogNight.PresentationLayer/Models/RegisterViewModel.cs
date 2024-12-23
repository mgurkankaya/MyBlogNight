﻿using System.ComponentModel.DataAnnotations;

namespace MyBlogNight.PresentationLayer.Models
{
    public class RegisterViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Şifrelere birbiriyle uyumlu değil!")]
        public string ConfirmPassword { get; set; }
    }
}
