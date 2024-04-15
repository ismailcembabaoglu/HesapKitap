using HesapKitap.Application.DTOs.BaseModelDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapKitap.Application.DTOs
{
    public class UnderCategoryDTO:BaseModelDTO
    {
        public string UndurCategoryName { get; set; }
        public Guid CategoryId { get; set; }
        public string? CategoryName { get; set; }
    }
}
