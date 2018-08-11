using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.DAO.Calendar;
using Gepa.Entities.Calendar;

namespace Gepa.Business.Calendar
{
    public class SchoolCalendarServiceImpl : ISchoolCalendarService
    {
        private ISchoolCalendarDAO _schoolCalendarDAO;

        public SchoolCalendarServiceImpl(ISchoolCalendarDAO schoolCalendarDAO)
        {
            _schoolCalendarDAO = schoolCalendarDAO;
        }

        public void DeleteSchoolCalendar(SchoolCalendarVO schoolCalendar)
        {
            _schoolCalendarDAO.DeleteSchoolCalendar(schoolCalendar);
        }

        public SchoolCalendarVO FindSchoolCalendar(long schoolCalendarId)
        {
            return _schoolCalendarDAO.FindSchoolCalendar(schoolCalendarId);
        }

        public void IsertSchoolCalendar(SchoolCalendarVO newSchoolCalendar)
        {
            _schoolCalendarDAO.IsertSchoolCalendar(newSchoolCalendar);
        }

        public void UpdateSchoolCalendar(SchoolCalendarVO schoolCalendar)
        {
            _schoolCalendarDAO.UpdateSchoolCalendar(schoolCalendar);
        }
    }
}
