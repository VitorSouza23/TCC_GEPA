namespace Gepa.Entities.Framework.Entities.Calendar
{
    using Gepa.Entities.Framework.Entities.ClassPlans;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClassSchedule")]
    public partial class ClassSchedule : AbstractSchoolEvent
    {
        public virtual SchoolCalendar SchoolCalendar { get; set; }

        public virtual ClassPlan ClassPlan { get; set; }
    }
}
