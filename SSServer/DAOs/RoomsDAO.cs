using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SSCommon.Models;
using SSServer._Core.Base;
using SSServer._Core.Context;
using System.Collections.Generic;
using System.Linq;

namespace SSServer.DAOs
{
    /// <summary>
    /// RoomListDAO
    /// </summary>
    public class RoomsDAO : BaseDAO
    {
        /// <summary>
        /// RoomListDAO constructor
        /// </summary>
        /// <param name="context"></param>
        /// <param name="logger"></param>
        /// <param name="userInfo"></param>
        public RoomsDAO(SSContext context, ILogger logger, Users userInfo) : base(logger, userInfo)
        {
            this.Context = context;
        }

        /// <summary>
        /// DBContext
        /// </summary>
        private SSContext Context { get; set; }

        /// <summary>
        /// Get room infomation list
        /// </summary>
        /// <returns></returns>
        public List<RoomList> GetRoomList()
        {
            return this.Context.Rooms.ToList();
        }

    }
}
