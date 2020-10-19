using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SSCommon.Models;
using SSCommon.Utility;
using SSServer._Core.Const;
using System.Configuration;

namespace SSServer._Core.Context
{
    public class SSContext : DbContext
    {
        public SSContext()
        {

        }

        public static readonly ILoggerFactory _loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
       
        #region DbSet

        public DbSet<UserInfo> Users { get; set; }

        #endregion DbSet

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connectString = ConfigurationManager.ConnectionStrings[SSServerConst.SSContext].ConnectionString;

            optionsBuilder
                .UseLoggerFactory(_loggerFactory)
                .UseSqlServer(connectString);
        }
    }
}
