using HesapKitap.Domain.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapKitap.Domain.Models
{
    public class AccountType:BaseModel
    {
        public string AccountTypeName { get; set; }
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public ICollection<Account>? Accounts { get; set; }
    }
}
