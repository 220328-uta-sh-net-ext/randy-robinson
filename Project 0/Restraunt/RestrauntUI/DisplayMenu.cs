using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestrauntUI;
using RestrauntBL;
using UserModel;
// -display details of a restaurant for user
namespace RestrauntUI
{
    // The following code fragments or other commented out fragments are subject to change (As I am creating application).

    public class DisplayMenu 
    {
        // Create Menu for user to 
        private string RestrauntName { get; set; }
        private int RestrauntRating { get; set; }
        Restaurant starterRestaurant= new Restaurant();

        public DisplayMenu()
        {
             Start();
        }
        public DisplayMenu( string restrauntName, int restrauntRating)
        {
            RestrauntName= restrauntName;
            RestrauntRating= restrauntRating;
            Start();
        }

        public void Start()
        {
            Console.WriteLine("Welcome to Restaurant Reviews!");
            Console.Write("Have you used our services before? (Y/N): ");
            var pressPlay= Console.ReadLine().ToUpper();
            if(pressPlay== "Y")
            {
                Console.WriteLine("Please enter your UserName: ");
                var userNameCheck = Console.ReadLine();
                userNameCheck = userNameCheck.ToUpper();
                
                
                //This is my logic I would like to call it directly. ie. UserNameInUse(userName);

            }
            else 
            {
                Console.Write("I'm  sorry, in order to use Restraunt Reviews you will need to create a username. \n Would you like to create a user name? (Y/N): ");
                pressPlay= Console.ReadLine();// Need GoTo statement to make this better.
                string userName = pressPlay.ToUpper();
                if (pressPlay!= "N")
                {
                    // Write logic to create new user
                    Console.Write("Please Enter FirstName: \n");
                    var firstName= Console.ReadLine();
                    Console.Write("Please Enter LastName: \n");
                    var lastName= Console.ReadLine();
                    Console.WriteLine("Please enter a UserName: \n" + "Please note that Username isn't case sensitive");
                    CreateUser iamNew= new CreateUser( firstName, lastName, userName);
                }
                else if(pressPlay== "N")
                {
                    Console.WriteLine("Thank you for your time. Have a wonderful day!");
                    
                }
            }
        }

        // After reviewing project zero template it was decided: For project0 we are not intergrating a creation of a user
        /* public string LastName { get; set; }
           public string FirstName { get; set; }
           public string UserName { get; set; }
        **/



    }
}
