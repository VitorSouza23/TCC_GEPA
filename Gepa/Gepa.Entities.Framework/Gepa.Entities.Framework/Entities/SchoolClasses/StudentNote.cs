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

        public virtual ClassDiary ClassDiary { get; set; }

        public virtual Evaluetion Evaluetion { get; set; }

        public virtual Student Student { get; set; }
    }
}
