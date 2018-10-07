using Gepa.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gepa.Site.Models.ClassPlans
{
    public class ClassPlanModel
    {
        public long Id { get; set; }
        [Required]
        [Display(Name = "Title", ResourceType = typeof(Resources.Language))]
        public string Title { get; set; }
        [Display(Name = "Description", ResourceType = typeof(Resources.Language))]
        public string Description { get; set; }
        [Display(Name = "Methodology", ResourceType = typeof(Resources.Language))]
        public string Methodology { get; set; }
        [Display(Name = "Date", ResourceType = typeof(Resources.Language))]
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Date { get; set; }
        [Display(Name = "Observations", ResourceType = typeof(Resources.Language))]
        public string Observation { get; set; }

        public List<LessonsContentModel> Contents { get; set; }
        public List<ClassGoalsModel> ClassGoals { get; set; }
        public List<ChoresModel> Chores { get; set; }
        public List<EvaluationModel> Evaluations { get; set; }
        public long TeacherId { get; set; }
    }
}