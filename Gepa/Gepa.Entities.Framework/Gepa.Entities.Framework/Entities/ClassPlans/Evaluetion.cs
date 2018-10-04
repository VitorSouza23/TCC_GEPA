namespace Gepa.Entities.Framework.Entities.ClassPlans
{
    using Gepa.Entities.Framework.Entities.SchoolClasses;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Evaluetion")]
    public partial class Evaluetion
    {
        public Evaluetion()
        {
            StudentNote = new List<StudentNote>();
        }

        public long EvaluetionId { get; set; }

        public string Description { get; set; }

        public List<StudentNote> StudentNote { get; set; }

        public long ClassPlanId { get; set; }

        public ClassPlan ClassPlan { get; set; }
    }
}
