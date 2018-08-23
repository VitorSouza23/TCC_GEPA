namespace Gepa.Entities.Framework.Entities.Calendar
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AbstractSchoolEvent")]
    public partial class AbstractSchoolEvent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AbstractSchoolEvent()
        {
        }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public long AbstractSchoolEventId { get; set; }

        public string Observation { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
