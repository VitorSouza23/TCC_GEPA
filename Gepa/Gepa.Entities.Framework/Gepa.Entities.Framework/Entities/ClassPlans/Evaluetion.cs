namespace Gepa.Entities.Framework.Entities.ClassPlans
{
    using Gepa.Entities.Framework.Entities.SchoolClasses;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Evaluetion")]
    public partial class Evaluetion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Evaluetion()
        {
            StudentNote = new HashSet<StudentNote>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long EvaluetionId { get; set; }

        public string Description { get; set; }

        public virtual ClassPlan ClassPlan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentNote> StudentNote { get; set; }
    }
}
