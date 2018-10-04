namespace Gepa.Entities.Framework.Entities.SchoolClasses
{
    using Gepa.Entities.Framework.Utils;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("StudentPresence")]
    public partial class StudentPresence
    {
        public long StudentPresenceId { get; set; }

        public string Observation { get; set; }

        public ClassPresenceEnum PesenceStatus { get; set; }

        public long StudentId { get; set; }

        public Student Student { get; set; }
    }
}
