using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantModels;

namespace ThisRestBL
{
    public interface IRestaurantLogic
    {
        /// <summary>
        /// Business Layer is responsible for further validation or processing of data obtained from either the database or the user
        /// What kind of processing? That all depends on the type of functionality you will be doing
        /// It can also hold any computation logic like calculating average, max or min values etc....
        /// </summary>
        public interface IRestaurantLogic
        {
            /// <summary>
            /// Add Restaurant to the database
            /// initial addition of a restaurant into the Database
            /// </summary>
            /// <param name="restaurant"></param>
            /// <returns></returns>
            Restaurant AddRestaurant(Restaurant restaurant);

            /// <summary>
            /// We will give the list of pokemons that are related to searched name
            /// </summary>
            /// <param name="restaurantName">This name parameter is used to filter Restaurants</param>
            /// <returns>Give the list of filtered pokemons via name</returns>
            List<Restaurant> SearchRestaurant(string restaurantName);

        }
    }
}
