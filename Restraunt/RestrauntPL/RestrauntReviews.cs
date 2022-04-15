
using RestrauntDL;
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
    abstract class RestrauntReviews
    {
        public string ReviewId { get; set; }
        public string ReviewName { get ; set; }
        public int ReviewCount { get; set; }
        public float ReviewScore { get; set; }

        // Code snipit taken and modified. Created by @pushpinder 
       
        // AddUser -> an abstract method with only method declaration and no implementation
        public abstract void Add(RestrauntDL.Employee employee);
        public abstract void Add(RestrauntDL.UserName userName);
        public abstract void Remove(RestrauntDL.Employee employee);
        //RemoveUser -> method to remove user.
        public abstract void Delete(RestrauntDL.UserName userName);
        //FindRestaunt : // This will take in a string and compare if the restraunts names match. If the they match return a value
        public abstract RestrauntBL.ReviewName SearchRestraunt(StringComparer comparer);

    }
}