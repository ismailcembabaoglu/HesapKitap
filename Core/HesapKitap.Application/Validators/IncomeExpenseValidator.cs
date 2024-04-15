using FluentValidation;
using HesapKitap.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapKitap.Application.Validators
{
    public class IncomeExpenseValidator:AbstractValidator<IncomeExpenseDTO>
    {
        public IncomeExpenseValidator()
        {
            RuleFor(c => c.Tutar).NotEmpty().WithMessage("Tutar alanı boş geçilemez!!");
            RuleFor(c => c.IncomeExpenseType).NotEmpty().WithMessage("Gelir Gider tipi boş geçilemez!!");
        }
    }
}
