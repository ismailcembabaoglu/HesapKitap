using FluentValidation;
using HesapKitap.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapKitap.Application.Validators
{
    public class AccountTypeValidator:AbstractValidator<AccountTypeDTO>
    {
        public AccountTypeValidator()
        {
            RuleFor(c => c.AccountTypeName).NotEmpty().WithMessage("Hesap Türü boş geçilemez!!");
        }
    }
}
