using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gepa.Site.Models.ClassPlans
{
    public class EvaluationModel
    {
        public long Id { get; set; }
        [Display(Name = "Description", ResourceType = typeof(Resources.Language))]
        public string EvaluationDescription { get; set; }
        public long ClassPlanId { get; set; }

    }
}