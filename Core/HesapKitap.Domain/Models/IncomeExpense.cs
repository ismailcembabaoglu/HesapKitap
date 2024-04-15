using HesapKitap.Domain.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapKitap.Domain.Models
{
    public class IncomeExpense:BaseModel
    {
        public string IncomeExpenseType { get; set; }
        public Guid AccountId { get; set; }
        public Account? Account { get; set; }
        public decimal Tutar { get; set; }
        public Guid CategoryId { get; set; }
        public Category? Category { get; set; }
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public string? UnderCategoryName { get; set; }
    }
}
