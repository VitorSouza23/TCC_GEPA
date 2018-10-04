namespace Gepa.Entities.Framework.Entities.SchoolClasses
{
    using Gepa.Entities.Framework.Entities.Users;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SchoolClass")]
    public partial class SchoolClass
    {
        public SchoolClass()
        {
            ClassDiary = new List<ClassDiary>();
            ClassFrequency = new List<ClassFrequency>();
            Students = new List<Student>();
        }

        public long SchoolClassId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string Observation { get; set; }

        public List<ClassDiary> ClassDiary { get; set; }

        public List<ClassFrequency> ClassFrequency { get; set; }

        public List<Student> Students { get; set; }

        public long SchoolId { get; set; }

        public School School { get; set; }
    }
}
