namespace ReviewModels
{
    public class Review
    {
        public DateTime Date { get; }
        public string Note { get; set; }
        public decimal Rating { get; set; }
        public string ?UserName { get; set; }
        public string ?RestaurantName { get; set; }
        
        public int ReviewID=0;
        public Review()
        {
            UserName = "-";
            RestaurantName = RestaurantName;
            Rating = 0;
            Note = "-";
            ReviewID++;
        }
        public Review(decimal rating, string note) 
        {
            UserName = UserName;
            RestaurantName = RestaurantName;
            Rating= rating;
            Note= note;
            ReviewID++;
        }
        public override string ToString()
        {
            string result = $"User Name: {UserName}\nRestaurantName: {RestaurantName}\nNote:{Note}";
            return result;
        }
    }
}