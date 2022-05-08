using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantModels;
using ThisRestDL;
namespace ThisRestUI
{
    internal class RestrauntOps
    {
        private readonly IRestaurantRepo repository;

        public RestrauntOps (IRestaurantRepo repository)
        {
            this.repository = repository;
        }

        public void GetRestaurants()
        {
            var restaurants = repository.GetRestaurants();
            foreach (var rest in restaurants)
            {
                Console.WriteLine(rest);
                Console.WriteLine("&&----            ----&&");
            }
        }
        /// <summary>
        /// only for testing purpose to check if pokemon was added
        /// </summary>
        public void AddDummyRestaurant()
        {
            Restaurant restaurant = new Restaurant()
            {
                RestaurantName = "thisTacoStand",
                RestaurantCity = "Macomb",
                RestaurantState = "IL",
                RestaurantZip= 61455, 
            };
            repository.AddRestaurant(restaurant);
        }
    }
}
