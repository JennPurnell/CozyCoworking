using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cozy_Coworking
{
    class CoCoProgram
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("*****Welcome to Cozy Coworking!*****");

            //Console.WriteLine("0. Exit");
            //Console.WriteLine("1. Become a Coworker");
            //Console.WriteLine("2. Become a Host");
            //Console.WriteLine("3. Already have an Account? Login:");
            //Console.WriteLine("Please select one of the options from above:");
            //var choice = Console.ReadLine();
            //switch (choice)
            //{
            //    case "0":
            //        return;
            //    case "1":
            //        var myCoworker = new Coworker();
            //        var emailAddress = Console.ReadLine();
            //        var myAccount = new UserName(emailAddress);
            //    case "2":

            //}

            

            //create an account object/instance
            var myHost = new Host();
            myHost.UserName = "Alice";
            myHost.EmailAddress = "test@test.com";

            var myAvailability = myHost.AddAvailability(4);
            Console.Write ($"{myHost.UserName} has {myHost.Availability} coworking spots available");

            myHost.DogCatFriendly = true;

            myHost.Description = ($" in a beautiful, quiet house in Redmond with desks for your coworking needs. Location {myHost.LocationID}");
            Console.WriteLine(myHost.Description);

            #region Rating
            //var myRating = myHost.CreateRating(int myStars);
            Console.WriteLine($"Rate {myHost.UserName} as a host. Please enter 1-5 stars.");
            int myStars = Convert.ToInt32(Console.ReadLine());
            //var myRating = myHost.CreateRating(myStars)
            //Console.WriteLine($"{myHost.UserName} has a rating of {myHost.Rating}");
            {
                if (myStars == 1)
                {
                    Console.WriteLine($"{myHost.UserName} has a rating of *");
                }
                if (myStars == 2)
                {
                    Console.WriteLine($"{myHost.UserName} has a rating of **");
                }
                if (myStars == 3)
                {
                    Console.WriteLine($"{myHost.UserName} has a rating of ***");
                }
                if (myStars == 4)
                {
                    Console.WriteLine($"{myHost.UserName} has a rating of ****");
                }
                if (myStars == 5)
                {
                    Console.WriteLine($"{myHost.UserName} has a rating of *****");
                }
                //else
                //    Console.WriteLine($"Not a valid rating");
            }
            #endregion

            var myHost2 = new Host("Rohit", "test@test.com");

            myAvailability = myHost2.AddAvailability(3);
            Console.Write($"{myHost2.UserName} has {myHost2.Availability} coworking spots available");

            myHost2.DogCatFriendly = false;

            myHost2.Description = ($" in a beautiful, quiet house in Redmond with desks for your coworking needs. Location {myHost2.LocationID}");
            Console.WriteLine(myHost2.Description);

            #region Rating
            //var myRating = myHost.CreateRating(int myStars);
            Console.WriteLine($"Rate {myHost2.UserName} as a host. Please enter 1-5 stars.");
            myStars = Convert.ToInt32(Console.ReadLine());

            {
                if (myStars == 1)
                {
                    Console.WriteLine($"{myHost2.UserName} has a rating of *");
                }
                if (myStars == 2)


                {
                    Console.WriteLine($"{myHost2.UserName} has a rating of **");
                }
                if (myStars == 3)
                {
                    Console.WriteLine($"{myHost2.UserName} has a rating of ***");
                }
                if (myStars == 4)
                {
                    Console.WriteLine($"{myHost2.UserName} has a rating of ****");
                }
                if (myStars == 5)
                {
                    Console.WriteLine($"{myHost2.UserName} has a rating of *****");
                }
                //else
                //    Console.WriteLine($"Not a valid rating");
            }
            #endregion

        }
    }
}
