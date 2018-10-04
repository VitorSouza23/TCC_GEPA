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
        public ClassDiary()
        {
            StudentNote = new List<StudentNote>();
        }

        public long ClassDiaryId { get; set; }

        public DateTime Date { get; set; }

        public List<StudentNote> StudentNote { get; set; }

        public long SchoolClassId { get; set; }

        public SchoolClass SchoolClass { get; set; }
    }
}
