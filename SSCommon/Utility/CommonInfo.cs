using Microsoft.Extensions.Logging;
using SSCommon.Models;

namespace SSCommon.Utility
{
    public static class CommonInfo
    {
        public static UserInfo UserInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
    }
}
