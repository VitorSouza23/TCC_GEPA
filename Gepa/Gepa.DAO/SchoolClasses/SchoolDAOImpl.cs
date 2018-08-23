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
        public SchoolDAOImpl(DbConnection dbConnectioOject) : base(dbConnectioOject)
        {
        }

        public void DeleteSchool(School school)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.School.Remove(school);
                em.SaveChanges();
            }
        }

        public School FindStudent(long schoolId)
        {
            School school = null;
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                school = em.School.Single(a => a.SchoolId == schoolId);
            }
            return school;
        }

        public void InsertSchool(School newSchool)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.School.Add(newSchool);
                em.SaveChanges();
            }
        }

        public void UpdateSchool(School school)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.Entry(school).State = System.Data.Entity.EntityState.Modified;
                em.SaveChanges();
            }
        }
    }
}
