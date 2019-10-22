using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookmi.Models
{
    public class ProviderAccount
    {
        public ProviderAccount()
        {

        }

        public string ServiceProvided { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string AboutProvider { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }


    }
}
