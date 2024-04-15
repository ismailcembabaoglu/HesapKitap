using HesapKitap.Application.DTOs.BaseModelDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapKitap.Application.DTOs
{
    public class CategoryDTO:BaseModelDTO
    {
        public string IncomeExpenseType { get; set; }
        public string CategoryName { get; set; }
        public Guid UserId { get; set; }
    }
}
