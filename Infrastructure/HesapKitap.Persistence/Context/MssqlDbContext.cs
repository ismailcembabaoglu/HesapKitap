using HesapKitap.Domain.Mappings;
using HesapKitap.Domain.Models;
using HesapKitap.Domain.Models.BaseModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace HesapKitap.Persistence.Context
{
    public class MssqlDbContext:DbContext
    {
        public MssqlDbContext(DbContextOptions<MssqlDbContext> options):base(options)
        {
            
        }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountType> AccountTypes { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<IncomeExpense> IncomeExpenses { get; set; }
        public virtual DbSet<UnderCategory> UnderCategories { get; set; }
        public virtual DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().HasOne(c => c.User).WithMany(c => c.Accounts).HasForeignKey(c => c.UserId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<AccountType>().HasOne(c => c.User).WithMany(c => c.AccountTypes).HasForeignKey(c => c.UserId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Category>().HasOne(c => c.User).WithMany(c => c.Categories).HasForeignKey(c => c.UserId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<IncomeExpense>().HasOne(c => c.Account).WithMany(c => c.IncomeExpenses).HasForeignKey(c => c.AccountId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<IncomeExpense>().HasOne(c => c.Category).WithMany(c => c.IncomeExpenses).HasForeignKey(c => c.CategoryId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<IncomeExpense>().HasOne(c => c.User).WithMany(c => c.IncomeExpenses).HasForeignKey(c => c.UserId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<UnderCategory>().HasOne(c => c.Category).WithMany(c => c.UnderCategories).HasForeignKey(c => c.CategoryId).OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<BaseModel>().UseTpcMappingStrategy();
            modelBuilder.ApplyConfiguration(new AccountMap());
            modelBuilder.ApplyConfiguration(new AccountTypeMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new IncomeExpenseMap());
            modelBuilder.ApplyConfiguration(new UnderCategoryMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
