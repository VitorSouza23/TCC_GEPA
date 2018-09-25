using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gepa.Site.Models.ClassPlans
{
    public class ClassGoalsModel
    {
        public long Id { get; set; }
        [Required]
        [Display(Name = "Goal", ResourceType = typeof(Resources.Language))]
        public string Objective { get; set; }
        [Display(Name = "IsCompletedGoal", ResourceType = typeof(Resources.Language))]
        public bool IsCompleted { get; set; }
    }
}