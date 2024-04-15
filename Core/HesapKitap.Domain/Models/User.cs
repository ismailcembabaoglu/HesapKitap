using HesapKitap.Domain.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapKitap.Domain.Models
{
    public class User : BaseModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EMailAddress { get; set; }

        public string Password { get; set; }

        public bool IsActive { get; set; }
        public ICollection<Account>? Accounts { get; set; }
        public ICollection<AccountType>? AccountTypes { get; set; }
        public ICollection<Category>? Categories { get; set; }
        public ICollection<IncomeExpense>? IncomeExpenses { get; set; }
    }
}
