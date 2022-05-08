
using ThisRestBL;
namespace ThisRestBL // This is the Business Logic for Restraunt
{
    /* add a new user
    - ability to search user as admin
    - display details of a restaurant for user
    - add reviews to a restaurant as a user
    - view details of restaurants as a user
    - view reviews of restaurants as a user
    - calculate reviews’ average rating for each restraunt
    - search restraunt (by name, rating, zip code, etc.)*/
    public class Restaurant
    {
        private int restaurantRating;

        //Properties of Restaurant

        public string RestaurantName { get; set; }
        public int ReviewCount { get; }
        public int RestaurantRating { get => restaurantRating; set => restaurantRating = value; }
        public string RestaurantCity { get; set; }
        public string RestaurantState { get; set; }
        public int RestaurantZip { get; set; }
        public string Review { get; set; }//This is for setting up Customer Reviews if they would like to participate etc...
        public string Menu { get; set; }//This is for setting up Customer Menu
        public int RestaurantIDseed = 334259;                               // AddUser -> an abstract method with only method declaration and no implementation

        public void AddRestraunt(string restrauntName) { }

        //FindRestaunt : // This will take in a string and compare if the restraunts names match.

        public Restaurant()
        {
            RestaurantName = "thisTacoStand";
           // ReviewCount = 0;
            RestaurantRating = 0;
            RestaurantCity = "Macomb";
            RestaurantState = "IL";
            RestaurantZip = 64155;
            RestaurantIDseed = RestaurantIDseed++;
        }


    }
}