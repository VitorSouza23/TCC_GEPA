using Gepa.Entities.ClassPlans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.DAO.ClassPlans
{
    public interface IClassPlanDAO
    {
        void InsertClassPlan(ClassPlanVO newClassPlan);
        void UpdateClassPlan(ClassPlanVO classPlan);
        void DeleteClassPlan(ClassPlanVO classPlan);
        ClassPlanVO FindClassPlan(long classPlanId);
    }
}
