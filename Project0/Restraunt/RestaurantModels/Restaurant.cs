namespace RestaurantModels
{
    public class Restaurant
    {
        private int restaurantRating;
        public string RestaurantName { get; set; }
        public int ReviewCount { get; }
        public int RestaurantAvgRating { get => restaurantRating; set => restaurantRating = value; }
        public string RestaurantCity { get; set; }
        public string RestaurantState { get; set; }
        public int RestaurantZip { get; set; }
        public string Review { get; set; }
        public int RestaurantIDseed = 334259;
        public Restaurant()
        {
            RestaurantName = "-";
            RestaurantAvgRating = 0;
            RestaurantCity = "Macomb";
            RestaurantState = "IL";
            RestaurantZip = 64155;
            RestaurantIDseed++;

        }
        public override string ToString()
        {
            string result = $"Name: {RestaurantName}\nRestaurantCity: {RestaurantCity}\nRestaurantState: {RestaurantState}\nRestaurantZip: {RestaurantZip}\nRestaurantID: {RestaurantIDseed}";
            
            return result;
        }
    }
}