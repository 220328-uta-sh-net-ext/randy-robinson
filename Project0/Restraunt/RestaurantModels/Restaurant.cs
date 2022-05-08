namespace RestaurantModels
{
    public class Restaurant
    {
        private int restaurantRating;
        public string RestaurantName { get; set; }
        public int ReviewCount { get; }
        public int RestaurantRating { get => restaurantRating; set => restaurantRating = value; }
        public string RestaurantCity { get; set; }
        public string RestaurantState { get; set; }
        public int RestaurantZip { get; set; }
        public string Review { get; set; }
        public int RestaurantIDseed = 334259;
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
        public override string ToString()
        {
            string result = $"Name: {RestaurantName}\nRestaurantCity: {RestaurantCity}\nRestaurantState: {RestaurantState}\nRestaurantZip: {RestaurantZip}\nRestaurantID: {RestaurantIDseed}";
            
            return result;
        }
    }
}