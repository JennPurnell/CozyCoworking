using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cozy_Coworking
{
    class Host
    {
        #region Statics
        private static int lastLocationID = 122;

        #endregion

        #region Properties

        public int LocationID { get; private set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }

        public int Availability { get; set; }

        public int Rating { get; private set; }

        public bool DogCatFriendly { get; set; }

        public string Description { get; set; }
        #endregion

        #region Methods 

        public Host() : this("", "")
        {
            //this.LocationID = ++lastLocationID;
            //this.UserName = userName;
            //this.EmailAddress = emailAddress;
        }

        public Host(string userName) : this(userName, "")
        {
            //this.LocationID = ++lastLocationID;
            //this.UserName = userName;
            //this.EmailAddress = emailAddress;
        }

        public Host(string userName, string emailAddress)
        {
            this.LocationID = ++lastLocationID;
            this.UserName = userName;
            this.EmailAddress = emailAddress;
        }

        //accept a coworker

        //show rating in stars - how to create an average from coworker input?  
        //public int CreateRating(int stars)
        //{
        //    if (stars == 1)
        //    {
        //        Rating = "*"
        //        return Rating;
        //    }
        //    if (stars == 2)
        //    {
        //        Rating = "**"
        //        return Rating;
        //    }
        //    if (stars == 3)
        //    {
        //        Rating = "***"
        //        return Rating;
        //    }
        //    if (stars == 4)
        //    {
        //        Rating = "****"
        //        return Rating;
        //    }
        //    if (stars == 5)
        //    {
        //        Rating = "****"
        //        return Rating;
        //    }
            //else
            //    Console.WriteLine($"Not a valid rating");
        //}


        //add availability to coworking spaces
        public int AddAvailability(int coworkSpaces)
        {
            Availability += coworkSpaces;
            return Availability;
        }

        //subtract availability to coworking spaces
        public int SubtractAvailability(int coworkSpaces)
        {
            Availability -= coworkSpaces;
            return Availability;
        }

        // 
        #endregion
    }
}
