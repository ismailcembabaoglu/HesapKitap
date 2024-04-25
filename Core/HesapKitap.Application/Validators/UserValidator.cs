using FluentValidation;
using HesapKitap.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapKitap.Application.Validators
{
    public class UserValidator:AbstractValidator<UserDTO>
    {
        public UserValidator()
        {
            RuleFor(c => c.FirstName).NotEmpty().WithMessage("İsim Boş Geçilemez!!");
            RuleFor(c => c.LastName).NotEmpty().WithMessage("Soyisim Boş Geçilemez!!");
            RuleFor(c => c.EMailAddress).NotEmpty().WithMessage("E-Mail adres Boş Geçilemez!!").EmailAddress().WithMessage("Email Geçersiz");
            RuleFor(c => c.Password).NotEmpty().WithMessage("Şifre Boş Geçilemez!!");
        }
    }
}
