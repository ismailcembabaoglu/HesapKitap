using FluentValidation;
using HesapKitap.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapKitap.Application.Validators
{
    public class CategoryValidator:AbstractValidator<CategoryDTO>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.IncomeExpenseType).NotEmpty().WithMessage("Gelir Gider tipi boş geçilemez!!");
            RuleFor(c => c.CategoryName).NotEmpty().WithMessage("Kategori Adı boş geçilemez!!");
        }
    }
}
