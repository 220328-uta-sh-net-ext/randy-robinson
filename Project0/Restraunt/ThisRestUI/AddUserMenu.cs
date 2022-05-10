using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserModel;
using ThisRestBL;

namespace ThisRestUI
{
    public class AddUserMenu : IDisplayMenu
    {
        private static CreateUser newUser= new CreateUser();
        private readonly IUserLogic logic;

        public AddUserMenu(IUserLogic logic) { this.logic = logic; }
        public void Display()
        {
            Console.WriteLine("Enter User Information");
            Console.WriteLine("<5> User FirstName: " + newUser.FirstName);
            Console.WriteLine("<4> User LastName: " + newUser.LastName);
            Console.WriteLine("<3> User UserName: " + newUser.UserName);
            Console.WriteLine("<2> User Password: " + newUser.Password);
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
                        Log.Information("Adding a User - " + newUser.UserName);
                        logic.AddUser(newUser);
                        Log.Information("User added successfully");
                    }
                    catch (Exception ex)
                    {
                        Log.Warning("Failed to add the User ");
                        Console.WriteLine(ex.Message);
                    }
                    return "MainMenu";
                case "2":
                    Console.Write("Please enter the your Password: ");
                    if (Console.ReadLine() is string input)
                        newUser.Password = input;

                    return "AddUser";
                case "3":
                    Console.Write("Please enter a UserName: ");
                    if (Console.ReadLine() is string input1)
                        newUser.UserName = input1;
                    else
                        throw new InvalidDataException("end of input");
                    return "AddUser";
                case "4":
                    Console.Write("Please enter your LastName: ");
                    if (Console.ReadLine() is string input2)
                       newUser.LastName = input2;
                    else
                        throw new InvalidDataException("end of input");
                    return "AddUser";
                case "5":
                    Console.Write("Please enter your FirstName: ");
                    if (Console.ReadLine() is string input3)
                        newUser.FirstName = input3;
                    else
                        throw new InvalidDataException("end of input");
                    return "AddUser";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "AddUser";
            }
        }
    }
}
