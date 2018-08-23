namespace Gepa.Entities.Framework.Entities.SchoolClasses
{
    using Gepa.Entities.Framework.Utils;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StudentPresence")]
    public partial class StudentPresence
    {
        public long StudentPresenceId { get; set; }

        public string Observation { get; set; }

        public ClassPresenceEnum PesenceStatus { get; set; }

        public virtual ClassFrequency ClassFrequency { get; set; }

        public virtual Student Student { get; set; }
    }
}
