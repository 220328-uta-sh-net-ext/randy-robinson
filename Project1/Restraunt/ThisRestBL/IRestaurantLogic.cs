using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantModels;

namespace ThisRestBL
{
    public interface IRestaurantLogic : IRestaurantSearch
    {
        /// <summary>
        /// Business Layer is responsible for further validation or processing of data obtained from either the database or the user
        /// What kind of processing? That all depends on the type of functionality you will be doing
        /// It can also hold any computation logic like calculating average, max or min values etc....
        /// </summary>
        /// <returns></returns>
        
        /// <summary>
        /// Add Restaurant to the database
        /// initial addition of a restaurant into the Database
        /// </summary>
        /// <param name="restaurant"></param>
        /// <returns></returns>
        Restaurant AddRestaurant(Restaurant restaurant);

        /// <summary>
        /// We will give the list of Restaurant that are related to searched name
        /// </summary>
        /// <param name="restaurantName">This name parameter is used to filter Restaurants</param>
        /// <returns>Give the list of filtered pokemons via name</returns>
        List<Restaurant> SearchRestaurant(string restaurantName);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logic"></param>
        /// <returns></returns>
        Restaurant AddRestaurantMenu(IRestaurantLogic logic);

    }
    public interface IRestaurantSearch
    {
        /// <summary>
        /// Async method to return all Restaurants from DB. 
        /// Need to use Key word Await
        /// </summary>
        /// <returns>List<Restaurants></returns>
        Task<List<Restaurant>> SearchAllRestaurantsAsync();
        List<Restaurant> SearchAllRestaurants();
    }
}
