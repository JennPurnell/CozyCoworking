using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cozy_Coworking
{
    class Coworker
    {
        #region Properties

        public string UserName { get; set; }

        public string EmailAddress { get; set; }

        public string WorkCatagory { get; set; }

        public string Description { get; set; }
        #endregion

        #region Methods
        public Coworker() : this("", "")
        {
            //this.UserName = userName;
            //this.EmailAddress = emailAddress;
        }

        public Coworker(string userName) : this(userName, "")
        {
            //this.UserName = userName;
            //this.EmailAddress = emailAddress;
        }

        public Coworker(string userName, string emailAddress)
        {
            this.UserName = userName;
            this.EmailAddress = emailAddress;
        }

        //request a coworking space

        //rate a host

        //public int rateHost;

        //pick dates??

        #endregion
    }
}
