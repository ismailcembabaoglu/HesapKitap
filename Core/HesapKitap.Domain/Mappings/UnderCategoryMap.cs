using HesapKitap.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapKitap.Domain.Mappings
{
    public class UnderCategoryMap : IEntityTypeConfiguration<UnderCategory>
    {
        public void Configure(EntityTypeBuilder<UnderCategory> builder)
        {
           
        }
    }
}
