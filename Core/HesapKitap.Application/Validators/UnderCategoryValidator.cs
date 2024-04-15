using FluentValidation;
using HesapKitap.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapKitap.Application.Validators
{
    public class UnderCategoryValidator:AbstractValidator<UnderCategoryDTO>
    {
        public UnderCategoryValidator()
        {
            RuleFor(c => c.UndurCategoryName).NotEmpty().WithMessage("Alt Kategori alanı boş geçilemez !!");
        }
    }
}
