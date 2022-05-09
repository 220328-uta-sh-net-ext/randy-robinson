using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThisRestUI;
// -display details of a restaurant for user
namespace ThisRestUI
{
    // The following code fragments or other commented out fragments are subject to change (As I am creating application).

    public class DisplayMenu : IDisplayMenu
    {
        // Create Menu for user to interact with Restaurant App
        public void Display()
        {
            Console.WriteLine("Welcome to Restraunt Review App");
            Console.WriteLine("Please select from the following options: ");
            Console.Clear();
            Console.WriteLine("Press <3> To view all Restraunts to review");
            Console.WriteLine("Press <2> To view all Users");
            Console.WriteLine("Press <1> Add a Restraunt to app");
            Console.WriteLine("Press <0> Exit");
        }
        public string UserChoice()
        {
            // Console.ReadLine returns null if redirecting from a file and the file ends
            if (Console.ReadLine() is not string userInput)
                throw new InvalidDataException("end of input");

            switch (userInput)
            {
                case "0":
                    return "Exit";
                case "1":
                    return "AddRestaurant";
                case "2":
                    return "SearchPokemon";
                case "3":
                    return "GetAllPokemons";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press <enter> to continue");
                    Console.ReadLine();
                    return "MainMenu";
            }
        }
    }
}
