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
        public ClassGoalsDAOImpl() : base()
        {
        }

        public void DeleteClassGoals(ClassGoals classGoals)
        {
            using (EntityModel em = new EntityModel())
            {
                em.ClassGoals.Remove(classGoals);
                em.SaveChanges();
            }
        }

        public ClassGoals FindClassGoals(long classGoalsId)
        {
            ClassGoals classGoals = null;
            using (EntityModel em = new EntityModel())
            {
                classGoals = em.ClassGoals.Find(classGoalsId);
            }
            return classGoals;
        }

        public async Task<ClassGoals> FindClassGoalsAsync(long classGoalsId)
        {
            ClassGoals classGoals = null;
            using (EntityModel em = new EntityModel())
            {
                classGoals = await em.ClassGoals.FindAsync(classGoalsId);
            }
            return classGoals;
        }

        public void InsertClassGoals(ClassGoals newClassGoals)
        {
            using (EntityModel em = new EntityModel())
            {
                em.ClassGoals.Add(newClassGoals);
                em.SaveChanges();
            }
        }

        public void UpdateClassGoals(ClassGoals classGoals)
        {
            using (EntityModel em = new EntityModel())
            {
                em.Entry(classGoals).State = System.Data.Entity.EntityState.Modified;
                em.SaveChanges();
            }
        }
    }
}
