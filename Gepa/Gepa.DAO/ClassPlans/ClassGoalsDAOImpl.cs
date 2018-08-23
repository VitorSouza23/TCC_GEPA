using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.Entities.Framework;
using Gepa.Entities.Framework.Entities.ClassPlans;

namespace Gepa.DAO.ClassPlans
{
    public class ClassGoalsDAOImpl : AbstractDAO, IClassGoalsDAO
    {
        public ClassGoalsDAOImpl(DbConnection dbConnectioOject) : base(dbConnectioOject)
        {
        }

        public void DeleteClassGoals(ClassGoals classGoals)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.ClassGoals.Remove(classGoals);
                em.SaveChanges();
            }
        }

        public ClassGoals FindClassGoals(long classGoalsId)
        {
            ClassGoals classGoals = null;
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                classGoals = em.ClassGoals.Single(a => a.ClassGoalsId == classGoalsId);
            }
            return classGoals;
        }

        public void InsertClassGoals(ClassGoals newClassGoals)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.ClassGoals.Add(newClassGoals);
                em.SaveChanges();
            }
        }

        public void UpdateClassGoals(ClassGoals classGoals)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.Entry(classGoals).State = System.Data.Entity.EntityState.Modified;
                em.SaveChanges();
            }
        }
    }
}
