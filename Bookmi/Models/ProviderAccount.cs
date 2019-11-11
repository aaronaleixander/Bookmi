using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Required]
        public string UserName { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }


        public string AboutProvider { get; set; }

        [Required]
        public string EmailAddress { get; set; }


        public string PhoneNumber { get; set; }


    }
}
