namespace Gepa.Entities.Framework.Entities.SchoolClasses
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Student")]
    public partial class Student
    {
        public Student()
        {
            StudentNotes = new List<StudentNote>();
            StudentPresences = new List<StudentPresence>();
        }

        public long StudentId { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public string Observation { get; set; }

        public List<StudentNote> StudentNotes { get; set; }

        public List<StudentPresence> StudentPresences { get; set; }

        public long SchoolClassId { get; set; }

        public SchoolClass SchoolClass { get; set; }
    }
}
