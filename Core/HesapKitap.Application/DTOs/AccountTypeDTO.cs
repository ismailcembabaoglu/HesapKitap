using HesapKitap.Application.DTOs.BaseModelDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapKitap.Application.DTOs
{
    public class AccountTypeDTO:BaseModelDTO
    {
        public string AccountTypeName { get; set; }
        public Guid UserId { get; set; }
    }
}
