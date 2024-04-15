using HesapKitap.Application.DTOs.BaseModelDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapKitap.Application.DTOs
{
    public class AccountDTO:BaseModelDTO
    {
        public string AccountName { get; set; }
        public Guid AccountTypeId { get; set; }
        public string? AccountTypeName { get; set; }
        public Guid UserId { get; set; }
        public decimal Balance { get; set; }
    }
}
