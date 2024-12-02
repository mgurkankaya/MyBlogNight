using FluentValidation;
using MyBlogNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.BusinessLayer.ValidationRules.CategoryValidationRules
{
    public class CreateCategoryValidator : AbstractValidator<Category>
    {
        public CreateCategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adı boş bırakılamaz..!");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Kategori adı 3 karakterden az olamaz..!");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Kategori adı 20 karakterden fazla olamaz..!");
        }
    }
}