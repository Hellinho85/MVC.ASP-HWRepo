using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAppHW03.Models
{
    // Model class with required properties and information;
    public class Contact
    {
        // FirstName property with required (min and max length) validation form;
        [Required]
        [MinLength(3), MaxLength(25)]
        public string FirstName { get; set; }

        // LastName property with required (min and max length) validation form;
        [Required]
        [MinLength(3), MaxLength(25)]
        public string LastName { get; set; }

        // IsCloseFriend property with required validation;
        [Required]
        public bool IsCloseFriend { get; set; }

        // PhoneNumber property with required (range digits) validation form;
        [Required]
        [Range(10000000, 99999999999)]
        public long PhoneNumber { get; set; }
    }
}
