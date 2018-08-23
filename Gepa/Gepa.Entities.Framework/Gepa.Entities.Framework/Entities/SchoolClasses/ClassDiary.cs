namespace Gepa.Entities.Framework.Entities.SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClassDiary")]
    public partial class ClassDiary
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClassDiary()
        {
            StudentNote = new HashSet<StudentNote>();
        }

        public long ClassDiaryId { get; set; }

        public DateTime Date { get; set; }

        public virtual SchoolClass SchoolClass { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentNote> StudentNote { get; set; }
    }
}
