using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.Entities.Framework;
using Gepa.Entities.Framework.Entities.SchoolClasses;

namespace Gepa.DAO.SchoolClasses
{
    public class SchoolDAOImpl : AbstractDAO, ISchoolDAO
    {
        public SchoolDAOImpl() : base()
        {
        }

        public void DeleteSchool(School school)
        {
            using (EntityModel em = new EntityModel())
            {
                em.School.Remove(school);
                em.SaveChanges();
            }
        }

        public School FindStudent(long schoolId)
        {
            School school = null;
            using (EntityModel em = new EntityModel())
            {
                school = em.School.Find(schoolId);
            }
            return school;
        }

        public async Task<School> FindStudentAsync(long schoolId)
        {
            School school = null;
            using (EntityModel em = new EntityModel())
            {
                school = await em.School.FindAsync(schoolId);
            }
            return school;
        }

        public void InsertSchool(School newSchool)
        {
            using (EntityModel em = new EntityModel())
            {
                em.School.Add(newSchool);
                em.SaveChanges();
            }
        }

        public void UpdateSchool(School school)
        {
            using (EntityModel em = new EntityModel())
            {
                em.Entry(school).State = System.Data.Entity.EntityState.Modified;
                em.SaveChanges();
            }
        }
    }
}
