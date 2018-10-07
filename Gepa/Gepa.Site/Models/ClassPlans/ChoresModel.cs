using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gepa.Site.Models.ClassPlans
{
    public class ChoresModel
    {
        public long Id { get; set; }
        [Display(Name = "Description", ResourceType = typeof(Resources.Language))]
        public string Task { get; set; }
        [Display(Name = "IsCompletedTask", ResourceType = typeof(Resources.Language))]
        public bool IsCompletedTask { get; set; }
        public long ClassPlanId { get; set; }
    }
}