namespace Gepa.Entities.Framework.Entities.ClassPlans
{
    using Gepa.Entities.Framework.Entities.Users;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClassPlan")]
    public partial class ClassPlan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClassPlan()
        {
            Chores = new HashSet<Chores>();
            ClassGoals = new HashSet<ClassGoals>();
            Evaluetion = new HashSet<Evaluetion>();
            LessonsContent = new HashSet<LessonsContent>();
        }

        public long ClassPlanId { get; set; }

        public DateTime? Date { get; set; }

        public string Methodology { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public string Observation { get; set; }

        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chores> Chores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassGoals> ClassGoals { get; set; }

        public virtual Teacher Teacher { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evaluetion> Evaluetion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LessonsContent> LessonsContent { get; set; }
    }
}
