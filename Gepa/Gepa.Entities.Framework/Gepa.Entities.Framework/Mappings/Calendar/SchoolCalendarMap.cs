using Gepa.Entities.Framework.Entities.Calendar;
using System.Data.Entity.ModelConfiguration;

namespace Gepa.Entities.Framework.Mappings.Calendar
{
    public class SchoolCalendarMap : EntityTypeConfiguration<SchoolCalendar>
    {
        public SchoolCalendarMap()
        {
            HasKey(k => k.SchoolCalendarId);
            HasRequired(k => k.Teacher)
                .WithMany(b => b.SchoolCalendar)
                .HasForeignKey(k => k.TeacherId)
                .WillCascadeOnDelete();
        }
    }
}
