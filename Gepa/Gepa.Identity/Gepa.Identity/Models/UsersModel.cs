using Gepa.Entities.Framework.Entities.Users;
using Gepa.Identity.Base.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gepa.Identity.Models
{
    public class UsersModel
    {
        [Display(Name ="ID do Usuário")]
        public string UserId { get; set; }

        [Display(Name = "Nome de Usuário")]
        public string  UserName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Regra")]
        public string RolesNames { get; set; }
    }
}