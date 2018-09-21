using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gepa.Site.Models.ClassPlans
{
    public class LessonsContentModel
    {
        public long Id { get; set; }
        [Display(Name = "Content", ResourceType = typeof(Resources.Language))]
        public string ContentValue { get; set; }
    }
}