namespace Gepa.Entities.Framework.Entities.Calendar
{
    using Gepa.Entities.Framework.Entities.Users;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SchoolCalendar")]
    public partial class SchoolCalendar
    {
        public SchoolCalendar()
        {
            ClassSchedules = new List<ClassSchedule>();
            SchoolEvents = new List<SchoolEvent>();
        }

        public long SchoolCalendarId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string Observation { get; set; }

        public long TeacherId { get; set; }

        public Teacher Teacher { get; set; }

        public List<ClassSchedule> ClassSchedules { get; set; }

        public List<SchoolEvent> SchoolEvents { get; set; }
    }
}
