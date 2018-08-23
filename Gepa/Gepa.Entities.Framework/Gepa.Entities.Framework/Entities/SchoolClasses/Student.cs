namespace Gepa.Entities.Framework.Entities.SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            StudentNote = new HashSet<StudentNote>();
            StudentPresence = new HashSet<StudentPresence>();
        }

        public long StudentId { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public string Observation { get; set; }

        public virtual SchoolClass SchoolClass { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentNote> StudentNote { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentPresence> StudentPresence { get; set; }
    }
}
