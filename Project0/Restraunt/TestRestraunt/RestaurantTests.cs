using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantModels;
using UserModel;
using Xunit;

namespace TestRestraunt
{
    
    public class RestaurantTests
    {
        
        [Fact]
        ///
        ///

        public void AddRestaurantTesting()
        {
            Restaurant restaurant = new Restaurant();
            restaurant.RestaurantName = "thisTacoStand";
            restaurant.RestaurantZip = 61455;
            restaurant.RestaurantIDseed++;
            restaurant.RestaurantCity = "Macomb";
            restaurant.RestaurantState = "IL";

            Xunit.Assert.Equal(restaurant.RestaurantName, "thisTacoStand");
            Xunit.Assert.Equal(restaurant.RestaurantZip, 60455);
            Xunit.Assert.Equal(restaurant.RestaurantIDseed, 334260);
            Xunit.Assert.Equal(restaurant.RestaurantCity, "Macomb");
            Xunit.Assert.Equal(restaurant.RestaurantState, "IL");
        }
        [Fact]
        public void AddUserTesting()
        {
            CreateUser user = new CreateUser();
            user.UserName = "Havelpot";
            user.FirstName = "Randy";
            user.UserTagNumber++;
            user.LastName = "Robinson";
            user.Password = "Ts(9!!";

            Xunit.Assert.Equal(user.UserName, "Havelpt");
            Xunit.Assert.Equal(user.FirstName, "Randy");
            Xunit.Assert.Equal(user.LastName, "Robinson");
            Xunit.Assert.Equal(user.UserTagNumber, 3332980);
            Xunit.Assert.Equal(user.Password, "Ts(9!!");
        }
    }
}