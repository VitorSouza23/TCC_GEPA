namespace Gepa.Entities.Framework.Entities.Calendar
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SchoolEvent")]
    public partial class SchoolEvent : AbstractSchoolEvent
    { 
        public virtual SchoolCalendar SchoolCalendar { get; set; }
    }
}
