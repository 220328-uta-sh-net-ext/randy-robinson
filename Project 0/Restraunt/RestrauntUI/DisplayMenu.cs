using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestrauntUI;
// -display details of a restaurant for user
namespace RestrauntUI
{
    // The following code fragments or other commented out fragments are subject to change (As I am creating application).

    public class DisplayMenu
    {
        // Create Menu for user to 
        public string RestrauntName { get; set; }
        public int RestrauntRating { get; set; }
        public DisplayMenu( string restrauntName, int restrauntRating)
        {
            restrauntName = this.RestrauntName;
            restrauntRating= this.RestrauntRating;
            Start();
        }

        public void Start()
        {
            Console.WriteLine("Welcome to Restaurant Reviews!");
        }

        // After reviewing project zero template it was decided: For project0 we are not intergrating a creation of a user
        /* public string LastName { get; set; }
           public string FirstName { get; set; }
           public string UserName { get; set; }
        **/



    }
}
