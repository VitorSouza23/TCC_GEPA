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
    public class SchoolClassDAOImpl : AbstractDAO, ISchoolClassDAO
    {
        public SchoolClassDAOImpl(DbConnection dbConnectioOject) : base(dbConnectioOject)
        {
        }

        public void DeleteSchoolClass(SchoolClass schoolClass)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.SchoolClass.Remove(schoolClass);
                em.SaveChanges();
            }
        }

        public SchoolClass FindSchoolClass(long schoolClassId)
        {
            SchoolClass schoolClass = null;
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                schoolClass = em.SchoolClass.Find(schoolClassId);
            }
            return schoolClass;
        }

        public async Task<SchoolClass> FindSchoolClassAsync(long schoolClassId)
        {
            SchoolClass schoolClass = null;
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                schoolClass = await em.SchoolClass.FindAsync(schoolClassId);
            }
            return schoolClass;
        }

        public void InserSchoolClass(SchoolClass newSchoolClass)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.SchoolClass.Add(newSchoolClass);
                em.SaveChanges();
            }
        }

        public void UpdateSchoolClass(SchoolClass schoolClass)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.Entry(schoolClass).State = System.Data.Entity.EntityState.Modified;
                em.SaveChanges();
            }
        }
    }
}
