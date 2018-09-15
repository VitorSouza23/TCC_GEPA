using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.DAO.Calendar;
using Gepa.Entities.Framework.Entities.Calendar;

namespace Gepa.Business.Calendar
{
    public class SchoolCalendarServiceImpl : ISchoolCalendarService
    {
        private ISchoolCalendarDAO _schoolCalendarDAO;

        public SchoolCalendarServiceImpl(ISchoolCalendarDAO schoolCalendarDAO)
        {
            _schoolCalendarDAO = schoolCalendarDAO;
        }

        public void DeleteSchoolCalendar(SchoolCalendar schoolCalendar)
        {
            _schoolCalendarDAO.DeleteSchoolCalendar(schoolCalendar);
        }

        public SchoolCalendar FindSchoolCalendar(long schoolCalendarId)
        {
            return _schoolCalendarDAO.FindSchoolCalendar(schoolCalendarId);
        }

        public async Task<SchoolCalendar> FindSchoolCalendarAsync(long schoolCalendarId)
        {
            return await _schoolCalendarDAO.FindSchoolCalendarAsync(schoolCalendarId);
        }

        public void IsertSchoolCalendar(SchoolCalendar newSchoolCalendar)
        {
            _schoolCalendarDAO.IsertSchoolCalendar(newSchoolCalendar);
        }

        public void UpdateSchoolCalendar(SchoolCalendar schoolCalendar)
        {
            _schoolCalendarDAO.UpdateSchoolCalendar(schoolCalendar);
        }
    }
}
