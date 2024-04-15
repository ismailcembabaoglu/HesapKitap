using HesapKitap.Domain.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapKitap.Domain.Models
{
    public class Category:BaseModel
    {
        public string IncomeExpenseType { get; set; }
        public string CategoryName { get; set; }
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public ICollection<UnderCategory>? UnderCategories { get; set; }
        public ICollection<IncomeExpense>? IncomeExpenses { get; set; }

    }
}
