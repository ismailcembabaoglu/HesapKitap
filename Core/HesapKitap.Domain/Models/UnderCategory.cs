using HesapKitap.Domain.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapKitap.Domain.Models
{
    public class UnderCategory:BaseModel
    {
        public string UndurCategoryName { get; set; }
        public Guid CategoryId { get; set; }
        public Category? Category { get; set; }

    }
}
