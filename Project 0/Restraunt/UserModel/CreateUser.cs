using RestrauntUI;
using RestrauntModel;
using RestrauntBL;
namespace UserModel
{
    public class CreateUser
    { 
        //This member will create a User name and check to see if in use
        public void UserNameInitialize() {
            //There is more information needed for this logic.
            CreateUser iamNew = new CreateUser(FirstName, LastName, UserName);
            
        }
        
        //This member will allow for User name changes
        public void UserNameUpdate() { }
        
        //This member will allow for UserName already in Use and return a bool value
        public bool UserNameInUse(string usrName) { 
            
            if (!UserNameInUse(usrName))
                return false;
            else
                UserNameInitialize();
                AddToUserNameDirectory(usrName);
                return true;
        }
        public void AddToUserNameDirectory(string usrName) {
        
            
        }
        public CreateUser(string firstName, string lastName, string userName)
        {
            //Creation of Object NewUser not in use.
            FirstName = firstName;
            lastName = this.LastName;
            userName = this.UserName;
            //This will check if the name is in use first
            try
            {
                UserNameInUse(userName);
                if (!UserNameInUse(userName))
                {
                    UserNameInitialize();
                }
                else
                {
                    throw ArgumentOutOfRangeException("I'm sorry you will need enter another UserName {userName} Is in use.\n ");
                }; // I will return to this else statement.
            }

        }   
    }

}