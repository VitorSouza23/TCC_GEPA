using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gepa.Identity.Models
{
    public class RoleModel
    {
        [Display(Name = "Papél")]
        [Required]
        public string RoleName { get; set; }
        [Display(Name = "ID")]
        public string RoleId { get; set; }
    }
}