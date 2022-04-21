/* In the following example, the lambda expression x => x * x, which specifies a parameter
 * that's named x and returns the value of x squared, is assigned to a variable of a delegate type: 
 *
 * Func<int, int> square = x => x * x;
 *  Console.WriteLine(square(5));
 *  // Output:
 *  // 25
**/
///Below is the code program UI for Poke(Pokemon). 

global using Serilog;
using PokemonUI;
/*
//basic LINQ
// data source
int[] num = new int[] { 45, 56, 67, 87, 99, 98, 100 };
// create query
var query = from n in num
            where (n % 2) == 0 || (n % 3) == 0
            orderby n descending
            select n;
//var results = num.Where(x => x % 2 == 0);
//execute the query
foreach (var q in query)
{
    Console.WriteLine(q);
}*/

//create and configure our logger
/*Log.Logger = new LoggerConfiguration()
    .WriteTo.Console().MinimumLevel.Debug()
    .WriteTo.File("./Logs/user.txt").MinimumLevel.Debug().MinimumLevel.Information()// we want to save the ;ogs in this file
    .CreateLogger();
bool repeat = true;
IMenu menu = new MainMenu();
while (repeat)
{
    menu.Display();
    string ans = menu.UserChoice();
    switch (ans)
    {
        case "SearchPokemon":
            //call SearchPokemon method
            Log.Debug("Displaying SearchPokemon menu to the user");
            menu = new SearchPokemonMenu();
            break;
        case "AddPokemon":
            Log.Debug("Displaying AddPokemon Menu to the user");
            menu = new AddPokemonMenu();
            break;
        case "GetAllPokemons":
            Log.Debug("Displaying all pokemons to the user");
            Console.WriteLine("--------------Retreiving all pokemons---------------");
            PokemonOperations.GetAllPokemons();
            break;
        case "MainMenu":
            Log.Debug("Displaying Main menu to the user");
            menu=new MainMenu();
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
}*/
