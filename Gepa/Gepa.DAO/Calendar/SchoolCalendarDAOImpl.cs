using Gepa.Entities.Framework;
using Gepa.Entities.Framework.Entities.Calendar;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.DAO.Calendar
{
    public class SchoolCalendarDAOImpl : AbstractDAO, ISchoolCalendarDAO
    {
        public SchoolCalendarDAOImpl() : base()
        {
        }

        public void DeleteSchoolCalendar(SchoolCalendar schoolCalendar)
        {
            using (EntityModel em = new EntityModel())
            {
                em.SchoolCalendar.Remove(schoolCalendar);
                em.SaveChanges();
            }
        }

        public SchoolCalendar FindSchoolCalendar(long schoolCalendarId)
        {
            SchoolCalendar schoolCalendar = null;
            using (EntityModel em = new EntityModel())
            {
                schoolCalendar = em.SchoolCalendar.Find(schoolCalendarId);
            }
            return schoolCalendar;
        }

        public async Task<SchoolCalendar> FindSchoolCalendarAsync(long schoolCalendarId)
        {
            SchoolCalendar schoolCalendar = null;
            using (EntityModel em = new EntityModel())
            {
                schoolCalendar = await em.SchoolCalendar.FindAsync(schoolCalendarId);
            }
            return schoolCalendar;
        }

        public void IsertSchoolCalendar(SchoolCalendar newSchoolCalendar)
        {
            using (EntityModel em = new EntityModel())
            {
                em.SchoolCalendar.Add(newSchoolCalendar);
                em.SaveChanges();
            }
        }

        public void UpdateSchoolCalendar(SchoolCalendar schoolCalendar)
        {
            using (EntityModel em = new EntityModel())
            {
                em.Entry(schoolCalendar).State = System.Data.Entity.EntityState.Modified;
                em.SaveChanges();
            }
        }
    }
}
