using Gepa.Entities.Framework.Entities.Calendar;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Entities.Framework.Mappings.Calendar
{
    public class SchoolCalendarMap : EntityTypeConfiguration<SchoolCalendar>
    {
        public SchoolCalendarMap()
        {
            this.HasKey(k => k.SchoolCalendarId);
            this.HasMany(e => e.ClassSchedule)
                .WithRequired(e => e.SchoolCalendar)
                .WillCascadeOnDelete(false);
            this.HasMany(e => e.SchoolEvent)
                .WithRequired(e => e.SchoolCalendar)
                .WillCascadeOnDelete(false);
        }
    }
}
