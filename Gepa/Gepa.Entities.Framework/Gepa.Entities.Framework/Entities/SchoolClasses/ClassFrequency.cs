namespace Gepa.Entities.Framework.Entities.SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClassFrequency")]
    public partial class ClassFrequency
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClassFrequency()
        {
            StudentPresence = new HashSet<StudentPresence>();
        }

        public long ClassFrequencyId { get; set; }

        public DateTime Date { get; set; }

        public virtual SchoolClass SchoolClass { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentPresence> StudentPresence { get; set; }
    }
}
