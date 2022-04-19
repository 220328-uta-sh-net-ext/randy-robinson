namespace RestrantModel// This is the Data Logic of Restraunt
{
    public class CreateRestraunt
    {
        // Creating properties or attributes of class CreateRestraunt
        // Code snipits of 
        public string FirstName { get; set; }//This is for setting up Customer FirstName
        public string LastName { get; set; }//This is for setting up Customer lastName
        public string Review { get; set; }//This is for setting up Customer Reviews if they would like to participate etc...
        public string Menu { get; set; }//This is for setting up Customer Menu
        public string Employee { get; set; }//This is to check if there is an employee
        public string UserName { get; set; }//This is to set and check if there is a Username.
        //The CreatUser method will not be used.. I will comment this code block out as I will not use it.
        /*
        public void CreateUser (string firstName, string lastName)
        {
                FirstName= firstName;
                LastName= lastName;
                
        }
        **/
        public CreateRestraunt()// default constructor for CreateRestraunt()
        {
            //Reviewing nullable cases to see if applicable
            FirstName= "Jimmy";
            LastName= "RaceCarDriver";
            UserName = "Havelpot";
            Menu = " ** empty menu ** ";            
        }
        public CreateRestraunt(int y, int x) { }
    }
}