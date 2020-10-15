using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SSServer._Core.Context;
using System;
using System.Configuration;

namespace SSServer._Core.Factories
{
    public class SSDBContextFactory : IDisposable
    {
        public SSDBContextFactory()
        {
            //this.ConnectString = connectString;
            //this.LoggerFactory = loggerFactory;
            this.ConnectString = ConfigurationManager.ConnectionStrings[0].ConnectionString;
        }

        //public SSDBContextFactory(string connectString)
        //{
        //    this.ConnectString = connectString;
        //    //this.LoggerFactory = loggerFactory;
        //}

        private string ConnectString { get; set; }

        private SSContext SSContext { get; set; }

        //public ILoggerFactory LoggerFactory { get; }

        public SSContext GetSSContext()
        {
            DbContextOptionsBuilder<SSContext> optionsBuilder = new DbContextOptionsBuilder<SSContext>();

            //optionsBuilder.UseSqlServer(this.Context, opts => opts.CommandTimeout(this.Config.GetValue<int>("CommandTimeout")));
            optionsBuilder.UseSqlServer(this.ConnectString);
            //optionsBuilder.UseLoggerFactory(this.LoggerFactory);

            return new SSContext(optionsBuilder.Options);
        }

        //public SSContext GetSSContext()
        //{
        //    if (this.SSContext == null)
        //    {
        //        this.SSContext = this.GetSSContext();
        //    }

        //    return this.SSContext;
        //}

        public void Dispose()
        {
            if (this.SSContext != null)
            {
                this.SSContext.Dispose();
            }
        }

        public SSContext CreateDbContext()
        {
            DbContextOptionsBuilder<SSContext> options = new DbContextOptionsBuilder<SSContext>();

            options.UseSqlServer(this.ConnectString);

            return new SSContext(options.Options);
        }
    }
}
