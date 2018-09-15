using Gepa.Entities.Framework.Entities.ClassPlans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.DAO.ClassPlans
{
    public interface IClassPlanDAO
    {
        void InsertClassPlan(ClassPlan newClassPlan);
        void UpdateClassPlan(ClassPlan classPlan);
        void DeleteClassPlan(ClassPlan classPlan);
        ClassPlan FindClassPlan(long classPlanId);
        Task<ClassPlan> FindClassPlanAsync(long classPlanId);
    }
}
