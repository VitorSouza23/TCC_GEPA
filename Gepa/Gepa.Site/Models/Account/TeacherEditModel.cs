using Gepa.Entities.Framework.Utils;
using Gepa.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gepa.Site.Models.Account
{
    public class TeacherEditModel
    {
        [Required]
        [Display(Name = "CultureLanguage", ResourceType = typeof(Language))]
        public CultureLanguageEnum CultureLanguage { get; set; }

        [Required]
        public long TeacherId { get; set; }

        [Required]
        [Display(Name = "Name", ResourceType = typeof(Language))]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        [Display(Name = "UserName", ResourceType = typeof(Language))]
        [StringLength(50)]
        public string UserName { get; set; }
    }
}