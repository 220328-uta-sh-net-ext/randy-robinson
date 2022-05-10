/**
 * 
 * @Havelpot ~RandyERobinson The Solution appended to this UI of Restraunt will communicate to the user.
 * 
 * Functionality will be as follows:
    - add a new user
    - ability to search user as admin
    - display details of a restaurant for user
    - add reviews to a restaurant as a user
    - view details of restaurants as a user
    - view reviews of restaurants as a user
    - calculate reviews’ average rating for each restaurant
    - search restaurant (by name, rating, zip code, etc.)
 * 
 * 
 **/
global using Serilog;
using System.Data.SqlClient;
using System;
using ThisRestUI;
using RestaurantModels;
using UserModel;
using ReviewModels;
using ThisRestDL;
using ThisRestBL;



//create and configure our logger
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console().MinimumLevel.Debug()
    .WriteTo.File("../../../../ThisRestUI/user.txt").MinimumLevel.Debug().MinimumLevel.Information()// we want to save the ;ogs in this file
    .CreateLogger();
string connectionStringFilePath = "../../../../ThisRestDL/thisCommandString.txt";
string connectionString = File.ReadAllText(connectionStringFilePath);

IRestaurantRepo repository = new SqlRepository(connectionString);
IRestaurantLogic logic = new RestaurantLogic(repository);
IUserLogic ulogic = new UserLogic(repository);
RestrauntOps operations = new(repository);

bool repeat = true;
IDisplayMenu menu = new DisplayMenuStart();

while (repeat)
{
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
    {
        case "SearchRestaurant":
            //Calling SearchRestaurantMenu method
            Log.Debug("Displaying SearchRestaurant menu to the user");
            menu = new SearchRestaurantMenu(logic);
            break;
        case "AddRestaurant":
            Log.Debug("Displaying AddRestaurant Menu to the user");
            menu = new AddRestaurantMenu(logic); 
            break;
        case "GetRestaurants":
            Log.Debug("Displaying all restaurants to the user");
            Console.WriteLine("&&----       Retreiving all restaurants       ----&&");
            operations.GetRestaurants();
            break;
        case "MainMenu":
            Log.Debug("Displaying Main menu to the user");
            menu = new DisplayMenuStart();
            break;
        case "Exit":
            Log.Debug("Exiting the application");
            Log.CloseAndFlush();
            repeat = false;
            break;
        case "SearchUser":
            //Calling SearchUserMenu method
            Log.Debug("Displaying SearchRestaurant menu to the user");
            menu = new SearchUserMenu(ulogic);
            break;
        case "AddUser":
            //Calling SearchUserMenu method
            Log.Debug("Displaying SearchRestaurant menu to the user");
            menu = new AddUserMenu(ulogic);
            break;

        default:
            Console.WriteLine("View does not exist");
            Console.WriteLine("Please press <enter> to continue");
            Console.ReadLine();
            break;
    }
}
