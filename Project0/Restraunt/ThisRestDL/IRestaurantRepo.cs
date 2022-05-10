using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantModels;
using ReviewModels;
using UserModel;

namespace ThisRestDL
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
        /// <summary>
        /// This method returns all Reviews
        /// </summary>
        /// <returns></returns>
        List<Review> GetReviews();

        /// <summary>
        /// This method adds a review
        /// </summary>
        /// <param name="review"></param>
        /// <returns></returns>
        Review AddReview(Review review);
        /// <summary>
        /// List all Users in the database
        /// </summary>
        /// <returns></returns>
        List<CreateUser> createUsers();
        /// <summary>
        /// Adds User to Database
        /// </summary>
        /// <param name="createUser"></param>
        /// <returns></returns>
        CreateUser AddUser(CreateUser createUser);


    }
}
