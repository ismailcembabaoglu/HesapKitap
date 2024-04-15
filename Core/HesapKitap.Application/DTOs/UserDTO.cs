using HesapKitap.Application.DTOs.BaseModelDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapKitap.Application.DTOs
{
    public class UserDTO:BaseModelDTO
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EMailAddress { get; set; }

        public string Password { get; set; }

        public bool IsActive { get; set; }
    }
}
