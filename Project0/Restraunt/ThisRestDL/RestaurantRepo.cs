using System.Text.Json;
using System.Data;
using Microsoft.SqlServer;
using System.Data.SqlClient;
using RestaurantModels;
using UserModel;
using ReviewModels;

namespace ThisRestDL
{
    public class RestaurantRepo : IRestaurantRepo
    {

        readonly string filePath = "../../../ThisRestDL/Restaurants.json";
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
        public CreateUser AddUser(CreateUser createUser)
        {//throw new NotImplementedException();

            List<CreateUser>? user = CreateUsers();
            user.Add(createUser);
            string? restaurantString = JsonSerializer.Serialize<List<CreateUser>>(user, new JsonSerializerOptions { WriteIndented = true });
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
            return createUser;
        }
        public List<CreateUser> CreateUsers()
        {
            try
            {
                jsonString = File.ReadAllText(filePath + "Users.json");
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
                return System.Text.Json.JsonSerializer.Deserialize<List<CreateUser>>(jsonString)!;
            throw new InvalidDataException("json data missing or invalid");
        }

        //No use ATM may delete later.
        public bool IsDuplicate(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

    }
}
