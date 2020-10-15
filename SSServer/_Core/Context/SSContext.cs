using Microsoft.EntityFrameworkCore;
using SSCommon.Models;
using SSServer._Core.Base;
using System.Configuration;

namespace SSServer._Core.Context
{
    public class SSContext : DbContext
    {
        public SSContext(DbContextOptions options) : base(options)
        {

        }

        #region DbSet

        public DbSet<RoomList> Rooms { get; set; }
        public DbSet<Users> Users { get; set; }

        #endregion DbSet

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectString = ConfigurationManager.ConnectionStrings[0].ConnectionString;

            optionsBuilder.UseSqlServer(connectString);
        }
    }
}
