using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisRestDL
{
    public class SqlRepository : IRestaurantRepo
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
        public List<Restaurant> GetAllRestrauntsConnected()
        {
            string commandString = "SELECT * FROM Restaurant;";

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

            
            var restaurant = new List<Restaurant>();
            //var newUser= new List<CreateUser>();
            // reader.Read advances the "cursor" to the next row
            // and returns true if it's not at the end of the data.
            while (reader.Read())
            {
                // different ways to access the data in the current row
                // - reader[columnName]
                //      the return type of this is object. probably need to cast the type.
                // - reader.Get_____(columnIndex)~
                //      return type is whatever type you asked for
                // be aware of DBNull
                restaurant.Add(new Restaurant
                {
                    RestaurantName = reader.GetString(0),
                    RestaurantRating = reader.GetInt32(2),
                    RestaurantCity = reader.GetString(3),
                    RestaurantState = reader.GetString(4),
                    RestaurantZip = reader.GetInt32(5)
                });
            }
            return restaurant;
        }

        public List<Restaurant> GetRestaurants()
        {
            string commandString = "SELECT * FROM Restaurant.RestaurantID;";

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
                    RestaurantZip = (int)row[5]
                });
            }
            return restaurants;
        }
        public List<CreateUser> createUsers()
        {
            string commandString = "SELECT * FROM Restraunts.Users;";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            IDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new();
            connection.Open();
            adapter.Fill(dataSet); // this sends the query. DataAdapter uses a DataReader to read.
            connection.Close();

            var usersList = new List<CreateUser>();
            DataColumn userColumn = dataSet.Tables[0].Columns[2];
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                usersList.Add(new CreateUser                 {
                    UserTagNumber= (int)row[userColumn],
                    UserName = (string)row[3],
                    FirstName= (string)row[4],
                    LastName= (string)row[5]
                });
            }
            return usersList;
        }

        public Restaurant AddRestaurant(Restaurant restaurantToAdd)
        {
            string commandString = "INSERT INTO Restaurant (RestaurantName, RestaurantCity, RestaurantState, RestaurantZip, RestaurantAvgRating) " +
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
        public CreateUser AddUser(CreateUser createUser)
        {
            string commandString = "INSERT INTO Users (UserTagNumber, UserName, FirstName, LastName) " +
                     "VALUES (@userTag, @usrName, @firstName, @lastName);";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            command.Parameters.AddWithValue("@userTag", createUser.UserTagNumber++);
            command.Parameters.AddWithValue("@usrName", createUser.UserName);
            command.Parameters.AddWithValue("@firstName", createUser.FirstName);
            command.Parameters.AddWithValue("@lastName", createUser.LastName);
            connection.Open();
            command.ExecuteNonQuery();

            return createUser;
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
