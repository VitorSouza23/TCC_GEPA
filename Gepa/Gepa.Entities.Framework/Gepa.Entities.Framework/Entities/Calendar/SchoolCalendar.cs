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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SchoolCalendar()
        {
            ClassSchedule = new HashSet<ClassSchedule>();
            SchoolEvent = new HashSet<SchoolEvent>();
        }

        public long SchoolCalendarId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string Observation { get; set; }

        public long TeacherID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassSchedule> ClassSchedule { get; set; }

        public virtual Teacher Teacher { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SchoolEvent> SchoolEvent { get; set; }
    }
}
