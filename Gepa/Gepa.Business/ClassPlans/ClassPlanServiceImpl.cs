using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.DAO.ClassPlans;
using Gepa.Entities.ClassPlans;

namespace Gepa.Business.ClassPlans
{
    public class ClassPlanServiceImpl : IClassPlanService
    {
        private IClassPlanDAO _classPlanDAO;

        public ClassPlanServiceImpl(IClassPlanDAO classPlanDAO)
        {
            _classPlanDAO = classPlanDAO;
        }

        public void DeleteClassPlan(ClassPlanVO classPlan)
        {
            _classPlanDAO.DeleteClassPlan(classPlan);
        }

        public ClassPlanVO FindClassPlan(long classPlanId)
        {
            return _classPlanDAO.FindClassPlan(classPlanId);
        }

        public void InsertClassPlan(ClassPlanVO newClassPlan)
        {
            _classPlanDAO.InsertClassPlan(newClassPlan);
        }

        public void UpdateClassPlan(ClassPlanVO classPlan)
        {
            _classPlanDAO.UpdateClassPlan(classPlan);
        }
    }
}
