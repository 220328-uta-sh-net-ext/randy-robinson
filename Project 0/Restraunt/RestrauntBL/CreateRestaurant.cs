
namespace RestrauntModel// This is the Data Logic of Restraunt
{
    public class CreateRestaurant
    {
        // Creating properties or attributes of class CreateRestraunt
        public static string RestaurantName { get; set; }//This is for setting up RestrauntName for user menu
        public string LastName { get; set; }//This is for setting up Customer lastName
        public string Review { get; set; }//This is for setting up Customer Reviews if they would like to participate etc...
        public string Menu { get; set; }//This is for setting up Customer Menu
        public string Employee { get; set; }//This is to check if there is an employee
        public static string UserName { get; set; }//This is to set and check if there is a Username.

        public CreateRestaurant()// default constructor for CreateRestraunt()
        {
            //Reviewing nullable cases to see if applicable
            RestaurantName= "Jimmy";
            LastName= "RaceCarDriver";
            UserName = "Havelpot";
            Menu = " ** empty menu ** ";            
        }
        public CreateRestaurant(int y, int x) { }
    }
}