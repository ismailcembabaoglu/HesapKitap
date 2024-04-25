using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapKitap.Persistence.Context
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MssqlDbContext>
    {
        public MssqlDbContext CreateDbContext(string[] args)
        {
            ConfigurationManager configurationManager = new ConfigurationManager();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/HesapKitap/Server"));
            configurationManager.AddJsonFile("appsettings.json");
            var builder = new DbContextOptionsBuilder<MssqlDbContext>();
            //var dbDataSource = new NpgsqlDataSourceBuilder(configurationManager.GetConnectionString("PostgreSql"));
            builder.UseSqlServer(configurationManager.GetConnectionString("Mssql"));
            return new MssqlDbContext(builder.Options);
        }
    }
}
