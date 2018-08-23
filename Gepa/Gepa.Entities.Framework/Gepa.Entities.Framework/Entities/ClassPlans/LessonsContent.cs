namespace Gepa.Entities.Framework.Entities.ClassPlans
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LessonsContent")]
    public partial class LessonsContent
    {
        public long LessonsContentId { get; set; }

        public string ContentValue { get; set; }

        public virtual ClassPlan ClassPlan { get; set; }
    }
}
