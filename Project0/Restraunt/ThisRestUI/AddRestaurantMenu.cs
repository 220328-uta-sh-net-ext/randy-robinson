using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantModels;
using UserModel;
using ReviewModels;
using ThisRestDL;
using ThisRestBL;


namespace ThisRestUI
{
    public class AddRestaurantMenu : IDisplayMenu
    {
        //static non-access modifier is needed to keep this variable consistent to all objects we create out of our AddRestaurantMenu
        private static Restaurant newRestaurant = new Restaurant();
        //private static CreateUser newUser = new CreateUser();
        private static Review thisReview = new Review();
        private readonly IRestaurantLogic logic;

        public AddRestaurantMenu(IRestaurantLogic logic)
        {
            this.logic = logic;
        }

        public void Display()
        {
            Console.WriteLine("Enter Restaurant Information");
            Console.WriteLine("<6> RestaurantZip: " + newRestaurant.RestaurantZip);
            Console.WriteLine("<5> RestaurantState: " + newRestaurant.RestaurantState);
            Console.WriteLine("<4> RestaurantName: " + newRestaurant.RestaurantName);
            Console.WriteLine("<3> RestaurantCity: " + newRestaurant.RestaurantCity);
            Console.WriteLine("<2> ReviewRestaurant: " + thisReview.Rating);

            Console.WriteLine("<1> Save");
            Console.WriteLine("<0> Go Back");
        }

        public string UserChoice()
        {
            // Console.ReadLine returns null if redirecting from a file and the file ends
            if (Console.ReadLine() is not string userInput)
                throw new InvalidDataException("end of input");
            switch (userInput)
            {
                case "0":
                    return "MainMenu";
                case "1":
                    try
                    {
                        Log.Information("Adding a Restauraunt - " + newRestaurant.RestaurantName);
                        logic.AddRestaurant(newRestaurant);
                        Log.Information("Restaurant added successfully");
                    }
                    catch (Exception ex)
                    {
                        Log.Warning("Failed to add the restaurant ");
                        Console.WriteLine(ex.Message);  
                    }
                    return "MainMenu";
                case "2":
                    Console.Write("Please enter a Review : 1 through 5 <5> being the highest review: ");
                    thisReview.Rating = Convert.ToInt32(Console.ReadLine());
                    return "AddRestaurant";
                case "3":
                    Console.Write("Please enter a City name: ");
                    if (Console.ReadLine() is string input)
                        newRestaurant.RestaurantCity = input;
                    else
                        throw new InvalidDataException("end of input");
                    return "AddRestaurant";
                case "4":
                    Console.Write("Please enter a name: ");
                    if (Console.ReadLine() is string input1)
                        newRestaurant.RestaurantName = input1;
                    else
                        throw new InvalidDataException("end of input");
                    return "AddRestaurant";
                case "5":
                    Console.Write("Please enter a name: ");
                    if (Console.ReadLine() is string input2)
                        newRestaurant.RestaurantState = input2;
                    else
                        throw new InvalidDataException("end of input");
                    return "AddRestaurant";
                case "6":
                    Console.Write("Please enter a name: ");
                    newRestaurant.RestaurantZip = Convert.ToInt32(Console.ReadLine());
                    return "AddRestaurant";
                /// Add more cases for any other attributes of pokemon
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "AddRestaurant";
            }
        }
    }
}
