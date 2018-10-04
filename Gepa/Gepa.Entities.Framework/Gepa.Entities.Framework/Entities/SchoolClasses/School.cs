namespace Gepa.Entities.Framework.Entities.SchoolClasses
{
    using Gepa.Entities.Framework.Entities.Users;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("School")]
    public partial class School
    {
        public School()
        {
            SchoolClasses = new List<SchoolClass>();
        }

        public long SchoolId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public List<SchoolClass> SchoolClasses { get; set; }

        public long TeacherId { get; set; }

        public Teacher Teacher { get; set; }
    }
}
