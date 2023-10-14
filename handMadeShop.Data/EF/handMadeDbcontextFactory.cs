using handMadeShop.Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace handMadeShop.Data.EF
{
    public class EShopDbContextFactory : IDesignTimeDbContextFactory<handMadeDBContext>
    {
        public handMadeDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("HANDMADEAPInhom7");

            var optionsBuilder = new DbContextOptionsBuilder<handMadeDBContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new handMadeDBContext(optionsBuilder.Options);
        }
    }
}
