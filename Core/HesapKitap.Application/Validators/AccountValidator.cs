using FluentValidation;
using HesapKitap.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapKitap.Application.Validators
{
    public class AccountValidator:AbstractValidator<AccountDTO>
    {
        public AccountValidator()
        {
            RuleFor(c => c.AccountName).NotEmpty().WithMessage("Hesap Adı boş geçilemez!!");
        }
    }
}
