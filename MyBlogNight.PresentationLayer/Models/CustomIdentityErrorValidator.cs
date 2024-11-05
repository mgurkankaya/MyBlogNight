using Microsoft.AspNetCore.Identity;

namespace MyBlogNight.PresentationLayer.Models
{
    public class CustomIdentityErrorValidator:IdentityErrorDescriber
    {

        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError
            {
                Code = "DuplicateEmail",
                Description = "Bu Email adresi sistemde kayıtlıdır."
            };
        }

        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Code = "PasswordTooShort",
                Description = "Şifre en az 6 karakter olmalıdır!"
            };
        }

        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresDigit",
                Description = "En az 1 rakam (0-9) içermelidir.!"
            };
        }

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresLower",
                Description = "En az 1 küçük harf (a-z) içermelidir!"
            };
        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresUpper",
                Description = "En az 1 büyük harf (A-Z) içermelidir!"
            };
        }

        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "En az 1 özel karakter (*,-,?,+,$...)  içermelidir!"
            };
        }
    }
}
