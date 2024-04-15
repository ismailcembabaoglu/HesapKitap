using HesapKitap.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapKitap.Domain.Mappings
{
    public class IncomeExpenseMap : IEntityTypeConfiguration<IncomeExpense>
    {
        public void Configure(EntityTypeBuilder<IncomeExpense> builder)
        {
            builder.Property(c => c.Tutar).HasPrecision(10, 2);
        }
    }
}
