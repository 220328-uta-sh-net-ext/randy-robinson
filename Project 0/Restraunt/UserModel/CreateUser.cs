using RestrauntUI;
using RestrauntBL;

// This Model will use SQL queries to update and manage the User Table

namespace UserModel
{
    public class CreateUser <T>
    {

        //Private properties of this class.
        private string UserName { get; set; }
        private string FirstName { get; set; }
        public string LastName { get; set; }
        public void AddUser() { }
        public void UpdateUserName(string userName) { }
        //RemoveUser -> method to remove user.
        public void DeleteUserName() { }
        //This member will create a User name and check to see if in use
        // I will need an interface to handle UserModel and ReviewModel
        public void UserNameInitialize() { }
        
        //This member will allow for User name changes
        //public List<T> UserNameUpdate<List> (T yeahINew, ) { }
        public List <T> Users { get; set; }
        //public void 

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
        public CreateUser(string firstName, string lastName, string userName)
        {
            //Creation of Object NewUser not in use.
            firstName = this.FirstName;
            lastName = this.LastName;
            userName = this.UserName;
            //This will check if the name is in use first
            
            
                UserNameInUse(userName);
                if (!UserNameInUse(userName))
                {
                    UserNameInitialize();
                }
                else
                {
                   // throw ArgumentOutOfRangeException("I'm sorry you will need enter another UserName {userName} Is in use.\n ");
                }; // I will return to this else statement.
            

        }   
    }

}