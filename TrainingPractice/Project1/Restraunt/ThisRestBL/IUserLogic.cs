using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserModel;
using ThisRestDL;

namespace ThisRestBL
{
    public interface IUserLogic
    {
        /// <summary>
        /// This will add User to DataBase
        /// </summary>
        /// <param name="logic"></param>
        /// <returns></returns>
        CreateUser AddUserMenu(IUserLogic logic);
        /// <summary>
        /// Search User in Database
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        List<CreateUser> SearchUser(string userName);
        /// <summary>
        /// This will Add User to DataBase
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        CreateUser AddUser(CreateUser user);
    }
}
