using HesapKitap.Domain.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapKitap.Domain.Models
{
    public class Account:BaseModel
    {
        public string AccountName { get; set; }
        public Guid AccountTypeId { get; set; }
        public AccountType? AccountType { get; set; }
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public decimal Balance { get; set; }
        public ICollection<IncomeExpense>? IncomeExpenses { get; set; }
    }
}
