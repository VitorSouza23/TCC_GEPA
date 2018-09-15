﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.Entities.Framework;
using Gepa.Entities.Framework.Entities.ClassPlans;

namespace Gepa.DAO.ClassPlans
{
    public class ClassPlanDAOImpl : AbstractDAO, IClassPlanDAO
    {
        public ClassPlanDAOImpl(DbConnection dbConnectioOject) : base(dbConnectioOject)
        {
        }

        public void DeleteClassPlan(ClassPlan classPlan)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.ClassPlan.Remove(classPlan);
                em.SaveChanges();
            }
        }

        public ClassPlan FindClassPlan(long classPlanId)
        {
            ClassPlan classPlan = null;
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                classPlan = em.ClassPlan.Single(a => a.ClassPlanId == classPlanId);
            }
            return classPlan;
        }

        public async Task<ClassPlan> FindClassPlanAsync(long classPlanId)
        {
            ClassPlan classPlan = null;
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                classPlan = await em.ClassPlan.FindAsync(classPlanId);
            }
            return classPlan;
        }

        public void InsertClassPlan(ClassPlan newClassPlan)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.ClassPlan.Add(newClassPlan);
                em.SaveChanges();
            }
        }

        public void UpdateClassPlan(ClassPlan classPlan)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.Entry(classPlan).State = System.Data.Entity.EntityState.Modified;
                em.SaveChanges();
            }
        }
    }
}
