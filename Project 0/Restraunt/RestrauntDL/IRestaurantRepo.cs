using RestrauntBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDL
{
    /// <summary>
    /// This is the Restraunt Delivery man.
    /// </summary>
    
    public interface IRestaurantRepo
    {
        ///<summary> 
        ///Adding the Restraunt to the Database
        ///</summary>
        /// <param name=" restaurantToAdd"></param> 
        /// <returns> The Restaurant added </returns>
        Restaurant AddRestaurant(Restaurant restaurantToAdd);
        /// <summary>
        /// This method returns all the Restaurants from the database
        /// </summary>
        /// <returns>Returns a collection of Restaurants as Generic List</returns>
        List<Restaurant> GetRestaurants();


    }
}
