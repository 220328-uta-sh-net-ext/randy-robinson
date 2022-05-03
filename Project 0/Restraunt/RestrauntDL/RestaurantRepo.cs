using RestaurantDL;
using RestrauntBL;
using ReviewModels;
using System.Text.Json;
using System.Data;
using Microsoft.SqlServer;
using System.Data.SqlClient;

namespace RestaurauntDL
{
    public class RestaurantRepo : IRestaurantRepo
    {
        
        readonly string filePath = "../../../RestaurantDL/Restaurants.json";
        string? jsonString;
        public Restaurant AddRestaurant(Restaurant restaurantToAdd)
        {//throw new NotImplementedException();

            List<Restaurant>? restaurants = GetRestaurants();
            restaurants.Add(restaurantToAdd);
            string? restaurantString = JsonSerializer.Serialize<List<Restaurant>>(restaurants, new JsonSerializerOptions { WriteIndented = true });
            try
            {
                File.WriteAllText(filePath + "Restaurants.json", restaurantString);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Please check the path, " + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Please check the file name, " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return restaurantToAdd;
        }

        public List<Restaurant> GetRestaurants()// This is an example of Deserializaeion
        {
            // throw new NotImplementedException();
            try
            {
                jsonString = File.ReadAllText(filePath + "Restaurants.json");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Please check the path, " + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Please check the file name, " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (!string.IsNullOrEmpty(jsonString))
                return System.Text.Json.JsonSerializer.Deserialize<List<Restaurant>>(jsonString)!;
            throw new InvalidDataException("json data missing or invalid");
        }


        public void AddReview(int restaurantId, Review reviewToAdd)
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> SearchRestaurants(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public bool IsDuplicate(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }
  
    }
}