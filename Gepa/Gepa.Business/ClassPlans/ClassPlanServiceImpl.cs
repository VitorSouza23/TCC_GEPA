using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.DAO.ClassPlans;
using Gepa.Entities.Framework.Entities.ClassPlans;
using Gepa.Entities.Framework.Entities.Users;

namespace Gepa.Business.ClassPlans
{
    public class ClassPlanServiceImpl : IClassPlanService
    {
        private IClassPlanDAO _classPlanDAO;

        public ClassPlanServiceImpl(IClassPlanDAO classPlanDAO)
        {
            _classPlanDAO = classPlanDAO;
        }

        public void DeleteClassPlan(ClassPlan classPlan)
        {
            _classPlanDAO.DeleteClassPlan(classPlan);
        }

        public ClassPlan FindClassPlan(long classPlanId)
        {
            return _classPlanDAO.FindClassPlan(classPlanId);
        }

        public async Task<ClassPlan> FindClassPlanAsync(long classPlanId)
        {
            return await _classPlanDAO.FindClassPlanAsync(classPlanId);
        }

        public void InsertClassPlan(ClassPlan newClassPlan)
        {
            _classPlanDAO.InsertClassPlan(newClassPlan);
        }

        public void UpdateClassPlan(ClassPlan classPlan)
        {
            _classPlanDAO.UpdateClassPlan(classPlan);
        }

        public async Task InsertClassPlanAsync(ClassPlan newClassPlan)
        {
            await _classPlanDAO.InsertClassPlanAsync(newClassPlan);
        }

        public List<ClassPlan> FindAllClassPlans()
        {
            return _classPlanDAO.FindAllClassPlans();
        }

        public async Task<List<ClassPlan>> FindAllTeacherClassPlans(long teacherId, bool loadAllData = false)
        {
            return await _classPlanDAO.FindAllTeacherClassPlans(teacherId, loadAllData);
        }
    }
}
