namespace Gepa.Entities.Framework.Entities.SchoolClasses
{
    using Gepa.Entities.Framework.Entities.ClassPlans;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StudentNote")]
    public partial class StudentNote
    {
        public long StudentNoteId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QuantitativeGrade { get; set; }

        [StringLength(10)]
        public string QualitativeNote { get; set; }

        public string Observation { get; set; }

        public long StudentId { get; set; }

        public Student Student { get; set; }
    }
}
