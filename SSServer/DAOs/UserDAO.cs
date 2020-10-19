using Microsoft.Extensions.Logging;
using SSCommon.Constant;
using SSCommon.Models;
using SSServer._Core.Base;
using SSServer._Core.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSServer.DAOs
{
    public class UserDAO
    {
        public UserDAO(SSContext context)
        {
            this.Context = context;
        }

        private SSContext Context { get; set; }

        public UserInfo GetUserInfo(string userId)
        {
            return this.Context.Users.Where(o => o.UserID == userId && o.Status != DATA_STATUS.Delete).FirstOrDefault();
        }
    }
}
