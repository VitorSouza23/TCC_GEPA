namespace Gepa.Entities.Framework.Entities.ClassPlans
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Chores
    {
        public long ChoresId { get; set; }

        public string Task { get; set; }

        public bool Completed { get; set; }

        public virtual ClassPlan ClassPlan { get; set; }
    }
}
