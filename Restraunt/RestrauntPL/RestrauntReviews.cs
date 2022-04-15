namespace RestrauntDL
{
    /* add a new user
    - ability to search user as admin
    - display details of a restaurant for user
    - add reviews to a restaurant as a user
    - view details of restaurants as a user
    - view reviews of restaurants as a user
    - calculate reviews’ average rating for each restaurant
    - search restaurant (by name, rating, zip code, etc.)*/
    abstract class RestrauntReviews
    {
        public string ReviewId { get; set; }
        public string ReviewName { get ; set; }
        public int ReviewCount { get; set; }
        public float ReviewScore { get; set; }
            
    }
}