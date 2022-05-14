using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ThisRestBL;
using ThisRestDL;
using RestaurantModels;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using RestAPIStart.Repository;

namespace RestAPIStart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestAPIController : ControllerBase// This allows for interactions between client and user
    {
        private readonly IJWTManagerRepository jwtRepo;
        private IRestaurantLogic createRestaurant;
        private IMemoryCache memoryCache;

        public RestAPIController(IJWTManagerRepository jwtRepo, IRestaurantLogic createRestaurant, IMemoryCache memoryCache)
        {
            this.jwtRepo = jwtRepo;
            this.createRestaurant = createRestaurant;
            this.memoryCache = memoryCache;
        }
        private static List<Restaurant> restaurants = new List<Restaurant>
        {
            new Restaurant{RestaurantName="thisTapasPlate", RestaurantCity="Macomb", RestaurantState= "IL", RestaurantZip= 64115},
            new Restaurant{RestaurantName="papaNoJohns", RestaurantCity="Sanfrancisco", RestaurantState="CA", RestaurantZip= 34578}
        };
        // Need a way to create Web Tabs to manipulate resources?? use this:
        [Authorize]
        [HttpGet] //This is the Get operator
        [ProducesResponseType(200, Type = typeof(List<Restaurant>))]
        public ActionResult<List<Restaurant>> Get()
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            try
            {
                if (!memoryCache.TryGetValue("restList", out restaurants)) {
                    restaurants= createRestaurant.SearchAllRestaurants();
                    memoryCache.Set("restList", restaurants, new TimeSpan(0,1,0));
                }                
            }
            catch (SqlException ex){ return NotFound(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }

            return Ok(restaurants);
        }

     }
}
