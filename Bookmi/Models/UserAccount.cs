using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookmi.Models
{
    public class UserAccount
    {
        public UserAccount()
        {

        }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string GetUserAccountByName(string fName, string lName) 
        {
            return FirstName + LastName;
        }

        public string GetUserAccountByEmail(string email) 
        {
            return EmailAddress;
        }





    }
}
