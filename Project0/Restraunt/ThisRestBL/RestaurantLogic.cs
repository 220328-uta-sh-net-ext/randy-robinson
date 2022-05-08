using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThisRestBL;
using RestaurantModels;
using ThisRestDL;


namespace ThisRestBL
{
    public class RestaurantLogic : IRestaurantLogic
    {
        private const int MaxRestaurant = 400;
        private readonly IRestaurantRepo repo;

        public RestaurantLogic(IRestaurantRepo repo)
        {
            this.repo = repo;
        }
       
        public Restaurant AddRestaurant(Restaurant restaurant)
        {

            //Validation process
            List<Restaurant> restaurants = repo.GetRestaurants();
            
            if (restaurants.Count < MaxRestaurant)
            {
                return repo.AddRestaurant(restaurant);
            }
            else
            {
                throw new Exception("You cannot add more than 400 Restraunts to the database.");
            }
        }

        public List<Restaurant> SearchRestaurant(string name)
        {
            var restaurants = repo.GetRestaurants();
            var filteredRestaurants = restaurants.Where(r => r.RestaurantName.Contains(name)).ToList(); // Method Syntax

            return filteredRestaurants;
        }
    }
}
