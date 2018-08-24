namespace Gepa.Entities.Framework.Entities.Users
{
    using Gepa.Entities.Framework.Entities.Accounts;
    using Gepa.Entities.Framework.Entities.Calendar;
    using Gepa.Entities.Framework.Entities.ClassPlans;
    using Gepa.Entities.Framework.Entities.SchoolClasses;
    using Gepa.Entities.Framework.Utils;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Teacher")]
    public partial class Teacher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Teacher()
        {
            ClassPlan = new HashSet<ClassPlan>();
            School = new HashSet<School>();
            SchoolCalendar = new HashSet<SchoolCalendar>();
            SchoolClass = new HashSet<SchoolClass>();
        }

        public long TeacherId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public CultureLanguageEnum CultureLanguage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassPlan> ClassPlan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<School> School { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SchoolCalendar> SchoolCalendar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SchoolClass> SchoolClass { get; set; }

        public virtual TeacherAccount TeacherAccount { get; set; }
    }
}
