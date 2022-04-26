
using RestrauntBL;
namespace RestrauntBL // This is the Business Logic for Restraunt
{
    /* add a new user
    - ability to search user as admin
    - display details of a restaurant for user
    - add reviews to a restaurant as a user
    - view details of restaurants as a user
    - view reviews of restaurants as a user
    - calculate reviews’ average rating for each restraunt
    - search restraunt (by name, rating, zip code, etc.)*/
    abstract class RestaurantReviews
    {
        //Properties of RestaurantReviews
        public string UserName { get; set; }
        public string RestaurantName { get ; set; }
        public int ReviewCount { get; set; }
        public float ReviewScore { get; }
        public string restaurantCity { get; set; }
        public string restaurantState { get; set; }
        public int restaurantZip { get; set; }
        public abstract void Restaurant();
        public abstract void RestaurantReview();
        

        // Code snipit taken and modified. Created by @pushpinder 
       
        // AddUser -> an abstract method with only method declaration and no implementation
        public abstract void AddUser(UserName employee);
        public abstract void Add(RestrauntBL.RestrauntName userName);
        public abstract void Update(RestrauntModel.Employee employee);
        public abstract void Remove(RestrauntModel.Employee employee);
        //RemoveUser -> method to remove user.
        public abstract void Delete(RestrauntModel.UserName userName);
        //FindRestaunt : // This will take in a string and compare if the restraunts names match. If the they match return a value
        public abstract RestrauntBL. SearchRestraunt(StringComparer comparer);

    }
}