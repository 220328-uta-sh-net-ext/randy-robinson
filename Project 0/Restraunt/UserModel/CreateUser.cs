using RestrauntUI;
using RestrauntModel;
namespace UserModel
{
    public class CreateUser : DisplayMenu
    { 
        
        public void NewUser ( string firstName, string lastName, string userName)
        {
              
            FirstName= firstName;
            LastName= lastName;
            UserName= userName;
            //This will check if the name is in use first
            UserNameInUse();
            if (!UserNameInUse())
            {
                UserNameInitialize();
            }
            else { } // I will return to this else statement.
                
        }
        //This member will create a User name and check to see if in use
        public void UserNameInitialize() { }
        
        //This member will allow for User name changes
        public void UserNameUpdate() { }
        
        //This member will allow for UserName already in Use and return a bool value
        public bool UserNameInUse() { return true; }

    }
}