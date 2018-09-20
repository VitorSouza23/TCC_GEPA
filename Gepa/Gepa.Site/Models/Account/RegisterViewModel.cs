using Gepa.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gepa.Site.Models.Account
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email", ResourceType = typeof(Language))]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessageResourceName = "PasswordWithInvalidSizeErrorMessage", MinimumLength = 6, ErrorMessageResourceType = typeof(Language))]
        [DataType(DataType.Password)]
        [Display(Name = "Password", ResourceType = typeof(Language))]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassword", ResourceType = typeof(Language))]
        [Compare("Password", ErrorMessageResourceName = "VerificationPasswordDoesNotMatchErrorMessage", ErrorMessageResourceType = typeof(Language))]
        public string ConfirmPassword { get; set; }
    }
}