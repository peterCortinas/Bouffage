using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web;

namespace Bouffage2.Web.Requests
{
    public class LoginRequest
    {
        [Required]
        [EmailAddress]
        [StringLength (50)]
        [MinLength (5)]
        public string UserName { get; set; }

        [Required]
        [StringLength (35)]
        [MinLength (5)]
        public string UserPassword { get; set; }
    }
}