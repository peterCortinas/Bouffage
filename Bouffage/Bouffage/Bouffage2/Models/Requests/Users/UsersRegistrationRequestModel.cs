using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bouffage2.Models.Requests.Users
{
    public class UsersRegistrationRequestModel : PasswordRequestModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    
    }
}







