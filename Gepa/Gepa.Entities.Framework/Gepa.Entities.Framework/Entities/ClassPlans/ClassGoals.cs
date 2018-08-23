namespace Gepa.Entities.Framework.Entities.ClassPlans
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClassGoals
    {
        public long ClassGoalsId { get; set; }

        public string Objective { get; set; }

        public virtual ClassPlan ClassPlan { get; set; }
    }
}
