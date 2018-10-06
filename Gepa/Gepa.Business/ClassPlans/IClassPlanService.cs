using Gepa.Entities.Framework.Entities.ClassPlans;
using Gepa.Entities.Framework.Entities.Users;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gepa.Business.ClassPlans
{
    public interface IClassPlanService : IGepaService
    {
        void InsertClassPlan(ClassPlan newClassPlan);
        void UpdateClassPlan(ClassPlan classPlan);
        void DeleteClassPlan(ClassPlan classPlan);
        ClassPlan FindClassPlan(long classPlanId);
        Task<ClassPlan> FindClassPlanAsync(long classPlanId);
        Task InsertClassPlanAsync(ClassPlan newClassPlan);
        List<ClassPlan> FindAllClassPlans();
    }
}
