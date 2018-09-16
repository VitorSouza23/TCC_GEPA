using Gepa.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gepa.Site.Models.Account
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "EmailOrUserName", ResourceType = typeof(Language))]
        public string EmailOrUserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password", ResourceType = typeof(Language))]
        public string Password { get; set; }
    }
}