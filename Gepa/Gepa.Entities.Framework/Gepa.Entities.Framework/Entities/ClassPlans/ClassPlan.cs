namespace Gepa.Entities.Framework.Entities.ClassPlans
{
    using Gepa.Entities.Framework.Entities.Users;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ClassPlan")]
    public partial class ClassPlan
    {
        public ClassPlan()
        {
            Chores = new List<Chores>();
            ClassGoals = new List<ClassGoals>();
            Evaluetions = new List<Evaluetion>();
            LessonsContents = new List<LessonsContent>();
        }

        public long ClassPlanId { get; set; }

        public DateTime? Date { get; set; }

        public string Methodology { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public string Observation { get; set; }

        public string Description { get; set; }

        public List<Chores> Chores { get; set; }

        public List<ClassGoals> ClassGoals { get; set; }

        public List<Evaluetion> Evaluetions { get; set; }

        public List<LessonsContent> LessonsContents { get; set; }

        public long TeacherId { get; set; }

        public Teacher Teacher { get; set; }
    }
}
