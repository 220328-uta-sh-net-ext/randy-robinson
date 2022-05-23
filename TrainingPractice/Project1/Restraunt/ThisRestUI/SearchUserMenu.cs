using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantModels;
using ThisRestBL;
using ThisRestDL;
using UserModel;

namespace ThisRestUI
{
    public class SearchUserMenu : IDisplayMenu
    {
        readonly IUserLogic logic;

        public SearchUserMenu(IUserLogic logic)
        {
            this.logic = logic;
        }
        public void Display()
        {
            Console.WriteLine("Press <2> By UserAdmin: ");
            Console.WriteLine("Press <1> By UserFirstName: ");
            Console.WriteLine("Press <0> Go Back");
        }
        public string UserChoice()
        {
            if (Console.ReadLine() is not string userInput)
                throw new InvalidDataException("end of input");

            switch (userInput)
            {
                case "0":
                    return "MainMenu";
                case "1":
                    // Logic to display results
                    Console.Write("Please enter the Users FirstName ");
                    if (Console.ReadLine() is not string name)
                        throw new InvalidDataException("end of input");
                    List<CreateUser>? results = logic.SearchUser(name);
                    if (results.Count > 0)
                    {
                        foreach (CreateUser? r in results)
                        {
                            Console.WriteLine("&&----          ----&&");
                            Console.WriteLine(r.ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine($"User with search string {name} not found");
                    }
                    Console.WriteLine("Press <enter> to continue");
                    Console.ReadLine();
                    return "MainMenu";
                case "2":

                    // Logic to display results
                    Console.Write("Please enter the UserName you would like to search: ");
                    if (Console.ReadLine() is not string usrName)
                        throw new InvalidDataException("end of input");
                    List<CreateUser>? userResults = logic.SearchUser(usrName);
                    if (userResults.Count > 0)
                    {
                        foreach (CreateUser? r in userResults)
                        {
                            Console.WriteLine("&&----          ----&&");
                            Console.WriteLine(r.ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine($"User with search string {usrName} not found");
                    }
                    Console.WriteLine("Press <enter> to continue");
                    Console.ReadLine();
                    return "MainMenu";
                default:
                    Console.WriteLine("Please enter a valid response");
                    Console.WriteLine("Please press <enter> to continue");
                    Console.ReadLine();
                    return "SearchUser";
            }
        }
    }
}
