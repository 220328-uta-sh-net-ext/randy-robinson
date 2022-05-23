using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserModel;
using ThisRestDL;

namespace ThisRestBL
{
    public class UserLogic : IUserLogic
    {
        private const int MaxUser = 400;
        private readonly IRestaurantRepo repo;
        private readonly IUserLogic logic;

        public UserLogic(IRestaurantRepo repo)
        {
            this.repo = repo;
        }
        public CreateUser AddUser(CreateUser user)
        {

            //Validation process
            List<CreateUser> _user = repo.CreateUsers();

            if (_user.Count < MaxUser)
            {
                return repo.AddUser(user);
            }
            else
            {
                throw new Exception("You cannot add more than 400 Users to the database.");
            }
        }
        public CreateUser AddUserMenu(IUserLogic logic)
        {
            logic = this.logic;
            throw new Exception(" ----- ");
        }

        public List<CreateUser> SearchUser(string name)
        {
            var user = repo.CreateUsers();
            var filteredUsers = user.Where(r => r.UserName.Contains(name)).ToList(); // Method Syntax

            return filteredUsers;
        }
    }
}
