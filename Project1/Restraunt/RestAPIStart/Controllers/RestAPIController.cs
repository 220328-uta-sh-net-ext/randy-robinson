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
        /// <summary>
        ///  Need a way to create Web Tabs to manipulate resources?? use these:
        /// </summary>
        /// </returns> This is the Get operator </returns>
        //The authenticate token below is commented out for App usability and for my own
        //sanity. Everything is currently public and everyone has access to change information
        //[Authorize]
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

        [HttpGet("name")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Restaurant> Get(string name)
        {
            var rest= createRestaurant.SearchRestaurant(name);
            if (rest.Count <= 0)
                return NotFound($"The Restaurant {name} is currently not in the Database");
            return Ok(rest);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Post([FromBody] Restaurant rest)
        {
            if (rest == null)
                return BadRequest("Invalid Restaurant, please add valid values");
            createRestaurant.AddRestaurant(rest);
            return CreatedAtAction("Get", rest);
        }
        [HttpPut]
        public ActionResult Put([FromQuery]Restaurant rest, [FromBody]string name)
        {
            if(name == null)
                return BadRequest("Not able to modify the Review of a Restaurant without the restaurant name.");
            try
            {
                var restaurant = restaurants.Find(y => y.RestaurantName.Contains(name));
                if (restaurant == null)
                    return NotFound("Restaurant Not Found");
                rest.RestaurantName = rest.RestaurantName.Trim();
                rest.RestaurantAvgRating = rest.RestaurantAvgRating;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Created("Get", rest);
        }

        [HttpDelete]
        public ActionResult Delete(string name)
        {
            if (name == null)
                return BadRequest("Unable to remove Restaurant without the Restaurant Name");
            var restaurant = restaurants.Find(y => y.RestaurantName.Contains(name));
            if (restaurant == null)
                return NotFound("Restaurant not found in database");
            restaurants.Remove(restaurant);
            return Ok($"Restaurant {name} Deleted from database");
        }
    
    }

}
