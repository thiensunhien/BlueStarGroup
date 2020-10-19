using Microsoft.Extensions.Logging;
using SSCommon.Models;
using System;

namespace SSServer._Core.Base
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseDAO : IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        public BaseDAO(ILogger logger, UserInfo userInfo)
        {
            this.Logger = logger;
            this.UserInfo = userInfo;
        }

        /// <summary>
        /// 
        /// </summary>
        protected ILogger Logger { get; set; }

        /// <summary>
        /// 
        /// </summary>
        protected UserInfo UserInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
        }
    }
}