using SSCommon.Models;
using SSServer._Core.Context;
using SSServer.DAOs;

namespace SSServer.Controllers
{
    public class LoginController
    {
        //private SSDBContextFactory Factory { get; set; }

        private SSContext Context { get; set; }

        private UserDAO UserDAO { get; set; }

        public LoginController()
        {
            //  Factory = new SSDBContextFactory();
            this.Context = new SSContext();
            this.UserDAO = new UserDAO(this.Context);
        }

        public UserInfo GetUserInfo(string userId)
        {
            return this.UserDAO.GetUserInfo(userId);
        }
    }
}
