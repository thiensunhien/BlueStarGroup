using Microsoft.Extensions.Logging;
using System;

namespace SSServer._Core.Base
{
    public class BaseLogic : IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        public BaseLogic(ILogger logger)
        {
            this.Logger = logger;
        }

        /// <summary>
        /// 
        /// </summary>
        protected ILogger Logger { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
        }
    }
}
