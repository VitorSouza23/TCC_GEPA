using Gepa.Entities.Framework.Entities.Calendar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.DAO.Calendar
{
    public interface ISchoolCalendarDAO
    {
        void IsertSchoolCalendar(SchoolCalendar newSchoolCalendar);
        void UpdateSchoolCalendar(SchoolCalendar schoolCalendar);
        void DeleteSchoolCalendar(SchoolCalendar schoolCalendar);
        SchoolCalendar FindSchoolCalendar(long schoolCalendarId);
    }
}
