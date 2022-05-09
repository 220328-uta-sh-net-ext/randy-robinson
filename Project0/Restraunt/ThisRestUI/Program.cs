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
    .WriteTo.File("./Logs/user.txt").MinimumLevel.Debug().MinimumLevel.Information()// we want to save the ;ogs in this file
    .CreateLogger();
string connectionStringFilePath = "../../../../PokemonDL/connection-string.txt";
string connectionString = File.ReadAllText(connectionStringFilePath);

IRestaurantRepo repository = new SqlRepository(connectionString);
IRestaurantLogic logic = new RestaurantLogic(repository);
RestrauntOps operations = new(repository);

bool repeat = true;
IDisplayMenu menu = new DisplayMenu();

while (repeat)
{
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
    {
        case "SearchPokemon":
            //call SearchPokemon method
            Log.Debug("Displaying SearchPokemon menu to the user");
            menu = new SearchRestaurantMenu(logic);
            break;
        case "AddPokemon":
            Log.Debug("Displaying AddPokemon Menu to the user");
            menu = new AddRestaurantMenu(logic); 
            break;
        case "GetAllPokemons":
            Log.Debug("Displaying all pokemons to the user");
            Console.WriteLine("--------------Retreiving all pokemons---------------");
            operations.GetRestaurants();
            break;
        case "MainMenu":
            Log.Debug("Displaying Main menu to the user");
            menu = new DisplayMenu();
            break;
        case "Exit":
            Log.Debug("Exiting the application");
            Log.CloseAndFlush();
            repeat = false;
            break;
        default:
            Console.WriteLine("View does not exist");
            Console.WriteLine("Please press <enter> to continue");
            Console.ReadLine();
            break;
    }
}