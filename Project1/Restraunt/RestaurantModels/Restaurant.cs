namespace RestaurantModels
{
    public class Restaurant
    {
        
        public string RestaurantName { get; set; }
        public int RestaurantAvgRating { get ; set; }
        public string RestaurantCity { get; set; }
        public string RestaurantState { get; set; }
        public int RestaurantZip { get; set; }
        public int RestaurantIDseed = 334259;
        public Restaurant()
        {
            RestaurantName = "-";
            RestaurantAvgRating = 0;s
            RestaurantCity = "Macomb";
            RestaurantState = "IL";
            RestaurantZip = 64155;
            RestaurantIDseed= RestaurantIDseed++;

        }
        public override string ToString()
        {
            string result = $"Name: {RestaurantName}\nRestaurantCity: {RestaurantCity}\nRestaurantState: {RestaurantState}\nRestaurantZip: {RestaurantZip}\nRestaurantID: {RestaurantIDseed}";
            
            return result;
        }
    }
}