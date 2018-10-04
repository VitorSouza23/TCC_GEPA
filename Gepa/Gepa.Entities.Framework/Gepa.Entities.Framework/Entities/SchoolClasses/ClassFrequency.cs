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
        public ClassFrequency()
        {
            StudentPresence = new List<StudentPresence>();
        }

        public long ClassFrequencyId { get; set; }

        public DateTime Date { get; set; }

        public List<StudentPresence> StudentPresence { get; set; }

        public long SchoolClassId { get; set; }

        public SchoolClass SchoolClass { get; set; }
    }
}
