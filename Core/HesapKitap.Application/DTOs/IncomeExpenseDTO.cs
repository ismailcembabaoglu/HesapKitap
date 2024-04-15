using HesapKitap.Application.DTOs.BaseModelDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HesapKitap.Application.DTOs
{
    public class IncomeExpenseDTO : BaseModelDTO
    {
        public string IncomeExpenseType { get; set; }
        public Guid AccountId { get; set; }
        public string? AccountName { get; set; }
        public decimal Tutar { get; set; }
        public Guid CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public Guid UserId { get; set; }
        public string? UnderCategoryName { get; set; }
    }
}
