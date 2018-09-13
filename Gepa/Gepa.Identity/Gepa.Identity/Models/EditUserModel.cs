using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace Gepa.Identity.Models
{
    public class EditUserModel
    {
        public EditUserModel()
        {
            AllAvailableRoles = new List<RoleModel>();
            RolesIds = new List<string>();
        }
        [Display(Name = "ID do Usuário")]
        public string UserId { get; set; }

        [Display(Name = "Nome de Usuário")]
        public string UserName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Papéis")]
        [BindRequired]
        public List<string> RolesIds { get; set; }
        [BindRequired]
        public List<RoleModel> AllAvailableRoles { get; set; }
    }
}