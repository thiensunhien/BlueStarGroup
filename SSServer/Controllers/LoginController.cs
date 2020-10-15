using SSCommon.Models;
using SSServer._Core.Context;
using SSServer._Core.Factories;
using SSServer.DAOs;
using System.Linq;

namespace SSServer.Controllers
{
    public class LoginController
    {
        private SSDBContextFactory Factory { get; set; }

        private SSContext Context { get; set; }

        private UserDAO UserDAO { get; set; }

        public LoginController()
        {
            Factory = new SSDBContextFactory();
            this.Context = Factory.GetSSContext();
            this.UserDAO = new UserDAO(Factory.GetSSContext());
        }

        public Users GetUserInfo(string userId)
        {
            return this.UserDAO.GetUserInfo(userId);
        }
    }
}
