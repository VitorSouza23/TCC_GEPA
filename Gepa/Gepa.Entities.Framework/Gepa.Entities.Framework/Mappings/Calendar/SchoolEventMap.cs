using Gepa.Entities.Framework.Entities.Calendar;
using System.Data.Entity.ModelConfiguration;

namespace Gepa.Entities.Framework.Mappings.Calendar
{
    public class SchoolEventMap : EntityTypeConfiguration<SchoolEvent>
    {
        public SchoolEventMap()
        {
            HasKey(k => k.AbstractSchoolEventId);
            HasRequired(k => k.SchoolCalendar)
                .WithMany(q => q.SchoolEvents)
                .HasForeignKey(k => k.SchoolCalendarId)
                .WillCascadeOnDelete();
        }
    }
}
