using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMigration.DataEF
{
    public class ContextDbFactory : IDesignTimeDbContextFactory<ContextDB>
    {
        public ContextDB CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
            var connectionstring = configuration.GetConnectionString("ManagerMusicDatabase");
            var optionBuilder = new DbContextOptionsBuilder<ContextDB>();
            optionBuilder.UseSqlServer(connectionstring);
            return new ContextDB(optionBuilder.Options);
        }
    }
}
