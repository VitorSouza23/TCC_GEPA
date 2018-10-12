using Gepa.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gepa.Site.Models.ClassPlans
{
    public class ClassPlanModel
    {
        public ClassPlanModel()
        {
            ClassGoals = new List<ClassGoalsModel>();
            Contents = new List<LessonsContentModel>();
            Chores = new List<ChoresModel>();
            Evaluations = new List<EvaluationModel>();
        }

        public long Id { get; set; }
        [Required]
        [Display(Name = "Title", ResourceType = typeof(Language))]
        public string Title { get; set; }
        [Display(Name = "Description", ResourceType = typeof(Language))]
        public string Description { get; set; }
        [Display(Name = "Methodology", ResourceType = typeof(Language))]
        public string Methodology { get; set; }
        [Display(Name = "Date", ResourceType = typeof(Language))]
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Date { get; set; }
        [Display(Name = "Observations", ResourceType = typeof(Language))]
        public string Observation { get; set; }
        [Display(Name = "Subject", ResourceType = typeof(Language))]
        public string Subject { get; set; }

        public List<LessonsContentModel> Contents { get; set; }
        public List<ClassGoalsModel> ClassGoals { get; set; }
        public List<ChoresModel> Chores { get; set; }
        public List<EvaluationModel> Evaluations { get; set; }
        public long TeacherId { get; set; }
    }
}