using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantModels;
using ThisRestBL;
using ThisRestDL;

namespace ThisRestUI
{
    public class SearchRestaurantMenu : IDisplayMenu
    {
        readonly IRestaurantLogic logic;

        public SearchRestaurantMenu(IRestaurantLogic logic)
        {
            this.logic = logic;
        }

        public void Display()
        {
            Console.WriteLine("Please select an option to filter the restaurants database: ");
            Console.WriteLine("Press <1> By RestaurantState");
            Console.WriteLine("Press <2> By RestaurantCity");
            Console.WriteLine("Press <1> By RestaurantName");
            Console.WriteLine("Press <0> Go Back");
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
                    // Logic to display results
                    Console.Write("Please enter the Restaurant name ");
                    if (Console.ReadLine() is not string name)
                        throw new InvalidDataException("end of input");
                    List<Restaurant>? results = logic.SearchRestaurant(name);
                    if (results.Count > 0)
                    {
                        foreach (Restaurant? r in results)
                        {
                            Console.WriteLine("&&----          ----&&");
                            Console.WriteLine(r.ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Restaurant with search string {name} not found");
                    }
                    Console.WriteLine("Press <enter> to continue");
                    Console.ReadLine();
                    return "MainMenu";
                case "2":

                    // Logic to display results
                    Console.Write("Please enter the Restaurant City  ");
                    if (Console.ReadLine() is not string city)
                        throw new InvalidDataException("end of input");
                    List<Restaurant>? cityResults = logic.SearchRestaurant(city);
                    if (cityResults.Count > 0)
                    {
                        foreach (Restaurant? r in cityResults)
                        {
                            Console.WriteLine("&&----          ----&&");
                            Console.WriteLine(r.ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Restaurant with search string {city} not found");
                    }
                    Console.WriteLine("Press <enter> to continue");
                    Console.ReadLine();
                    return "MainMenu";
                case "3":
                    // Logic to display results
                    Console.Write("Please enter the Restaurant State ex: <IL>  ");
                    if (Console.ReadLine() is not string state)
                        throw new InvalidDataException("end of input");
                    List<Restaurant>? stateResults = logic.SearchRestaurant(state);
                    if (stateResults.Count > 0)
                    {
                        foreach (Restaurant? r in stateResults)
                        {
                            Console.WriteLine("&&----          ----&&");
                            Console.WriteLine(r.ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Restaurant with search string {state} not found");
                    }
                    Console.WriteLine("Press <enter> to continue");
                    Console.ReadLine();
                    return "MainMenu";

                default:
                    Console.WriteLine("Please enter a valid response");
                    Console.WriteLine("Please press <enter> to continue");
                    Console.ReadLine();
                    return "SearchRestaurant";
            }
        }
    }
}
