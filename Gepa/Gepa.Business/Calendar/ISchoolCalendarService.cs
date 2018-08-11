using Gepa.Entities.Calendar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Business.Calendar
{
    public interface ISchoolCalendarService
    {
        void IsertSchoolCalendar(SchoolCalendarVO newSchoolCalendar);
        void UpdateSchoolCalendar(SchoolCalendarVO schoolCalendar);
        void DeleteSchoolCalendar(SchoolCalendarVO schoolCalendar);
        SchoolCalendarVO FindSchoolCalendar(long schoolCalendarId);
    }
}
