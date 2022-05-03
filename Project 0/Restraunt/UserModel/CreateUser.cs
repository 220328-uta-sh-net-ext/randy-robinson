using RestrauntUI;
using RestrauntBL;

// This Model will use SQL queries to update and manage the User Table

namespace UserModel
{
    public class CreateUser 
    {

        //Private properties of this class.
        private string UserName { get; set; }
        private string FirstName { get; set; }
        public string LastName { get; set; }
        public void UpdateUserName(string userName) { }
        //RemoveUser -> method to remove user.
        public void DeleteUserName() { }
        //This member will create a User name and check to see if in use
        // I will need an interface to handle UserModel and ReviewModel
        public List<CreateUser>? usrName= UserNameInitialize(string usrName ) { }
        
        //This member will allow for User name changes
        //public List<T> UserNameUpdate<List> (T yeahINew, ) { }
 

        //This member will allow for UserName already in Use and return a bool value
        public bool UserNameInUse(string usrName) { 
            
           //Need to check a list of users... would like to call them dynamically.
            
            if (!UserNameInUse(usrName))
                
                return false;
            else
                UserNameInitialize();
                AddToUserNameDirectory(usrName);
                return true;
        }
        public void AddToUserNameDirectory(string usrName) {
        
            
        }
        public CreateUser() { }
        
        public CreateUser(string firstName, string lastName, string userName)
        {
            //Creation of Object NewUser not in use.
            FirstName= firstName;
            LastName= lastName;
            UserName= userName;
            //This will check if the name is in use first
            UserNameInUse(userName);
                if (!UserNameInUse(userName))
                {
                    UserNameInitialize(userName);
                }
                else
                {
                   // throw ArgumentOutOfRangeException("I'm sorry you will need enter another UserName {userName} Is in use.\n ");
                }; // I will return to this else statement.
            

        }   
    }

}