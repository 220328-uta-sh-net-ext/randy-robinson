using RestaurantDL;
using RestrauntBL;
using ReviewModels;
using System.Text.Json;
using System.Data;
using Microsoft.SqlServer;
using System.Data.SqlClient;

namespace RestaurauntDL
{
    public class RestrauntRepo : IRestaurantRepo
    {
        public RestrauntRepo() { }


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

        /// <summary>
        /// describe the classe
        /// </summary>
        /// <remarks>
        /// more detailed explanations
        /// </remarks>
        public class SqlRepository : IRepository
        {
            readonly string connectionString;

            /// <summary>
            /// summary
            /// </summary>
            public SqlRepository(string connectionString)
            {
                this.connectionString = connectionString;
            }

            // specifically when SELECT statements and result sets are involved,
            // there are two approaches to writing the code.
            // this example uses "connected architecture"
            //    which involves - processing the result set while the connection is open
            //                   as you receive it row by row.

            //  in many practical applications, open connections to the database are
            //    a performance bottleneck. so we often prioritize keeping the connection
            //    open for the minimum possible time.

            // so the alternative is called "disconnected architecture"
            //    which involves using a DataAdapter to put the results in a DataSet
            //     then closing the connection
            //     then processing the data in the DataSet.

            // it's also possible to modify the DataSet and then treat those changes
            // as inserts, updates, and deletes to push to the database.
            public List<Pokemon> GetAllPokemonsConnected()
            {
                string commandString = "SELECT * FROM Pokemon;";

                // the connection (SqlConnection): represents a connection to a database.
                // needs a connection string to know how to connect and where the database is.
                // can Open and Close the connection. is IDisposable so you can have it automatically
                // close with the help of a using statement.
                using SqlConnection connection = new(connectionString);
                // the command (SqlCommand): encapsulates some SQL commands to send.
                //  it supports using SqlParameters for protecting from SQL injection.
                using IDbCommand command = new SqlCommand(commandString, connection);
                connection.Open();
                // the data reader (SqlDataReader): represents a response to a SqlCommand
                // having 1 or more result sets (because of 1 or more SELECT statements).
                // the data reader provides each row of the data immediately as it's
                // received over the network.
                using IDataReader reader = command.ExecuteReader();

                // TODO: leaving out the abilities for now
                var pokemons = new List<Pokemon>();
                // reader.Read advances the "cursor" to the next row
                // and returns true if it's not at the end of the data.
                while (reader.Read())
                {
                    // different ways to access the data in the current row
                    // - reader[columnName]
                    //      the return type of this is object. probably need to cast the type.
                    // - reader.Get_____(columnIndex)
                    //      return type is whatever type you asked for
                    // be aware of DBNull
                    pokemons.Add(new Pokemon
                    {
                        Name = reader.GetString(0),
                        Level = reader.GetInt32(2),
                        Attack = reader.GetInt32(3),
                        Defense = reader.GetInt32(4),
                        Health = reader.GetInt32(5)
                    });
                }
                return pokemons;
            }

            public List<Restaurant> s()
            {
                string commandString = "SELECT * FROM Pokemon;";

                using SqlConnection connection = new(connectionString);
                using SqlCommand command = new(commandString, connection);
                IDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new();
                connection.Open();
                adapter.Fill(dataSet); // this sends the query. DataAdapter uses a DataReader to read.
                connection.Close();

                var restaurants = new List<Restaurant>();
                DataColumn ratingColumn = dataSet.Tables[0].Columns[2];
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    restaurants.Add(new Restaurant
                    {    
                        RestaurantName = (string)row[0],
                        RestaurantRating = (int)row[ratingColumn],
                        RestaurantCity = (string)row[3],
                        RestaurantState = (string)row[4],
                        RestaurantZip = (int)row [5]
                    });
                }
                return restaurants;
            }

            public Restaurant AddRestaurant(Restaurant restaurantToAdd)
            {
                string commandString = "INSERT INTO Restaurant (RestaurantName, RestaurantCity, RestaurantState, RestaurantZip, RestaurantRating) " +
                    "VALUES (@restaurantName, @restaurantCity, @restaurantState, @restaurantZip, @restaurantRating);";

                using SqlConnection connection = new(connectionString);
                using SqlCommand command = new(commandString, connection);
                command.Parameters.AddWithValue("@restaurantName", restaurantToAdd.RestaurantName);
                command.Parameters.AddWithValue("@restaurantCity", restaurantToAdd.RestaurantCity);
                command.Parameters.AddWithValue("@restaurantState", restaurantToAdd.RestaurantState);
                command.Parameters.AddWithValue("@restaurantZip", restaurantToAdd.RestaurantZip);
                command.Parameters.AddWithValue("@restaurantCity", restaurantToAdd.RestaurantRating);
                connection.Open();
                command.ExecuteNonQuery();

                return restaurantToAdd;
            }

            /// <summary>
            /// The unsafe version.
            /// </summary>
            /// <param name="restaurantToAdd">the RestaurantBL model to add</param>
            /// <returns>the added restaurants</returns>
            public Restaurant AddRestaurants(Restaurant restaurantToAdd)
            {
                string commandString = "INSERT INTO Restaurant (RestaurantName, RestaurantCity, RestaurantState, RestaurantZip, RestaurantReview ) " +
                    $"VALUES ({restaurantToAdd.RestaurantName}, thisTacoStand, {restaurantToAdd.RestaurantCity} Macomb, {restaurantToAdd.RestaurantState} IL, {restaurantToAdd.RestaurantZip}, {restaurantToAdd.RestaurantRating};";

                using SqlConnection connection = new(connectionString);
                using SqlCommand command = new(commandString, connection);
                //command.Parameters.AddWithValue("@name", poke.Name);
                //command.Parameters.AddWithValue("@type", "Normal");
                //command.Parameters.AddWithValue("@level", poke.Level);
                //command.Parameters.AddWithValue("@attack", poke.Attack);
                //command.Parameters.AddWithValue("@defense", poke.Defense);
                //command.Parameters.AddWithValue("@health", poke.Health);
                connection.Open();
                command.ExecuteNonQuery();

                return restaurantToAdd;
            }
        }
    }
}