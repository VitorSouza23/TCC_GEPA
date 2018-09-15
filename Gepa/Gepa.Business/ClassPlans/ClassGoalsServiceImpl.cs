using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.DAO.ClassPlans;
using Gepa.Entities.Framework.Entities.ClassPlans;

namespace Gepa.Business.ClassPlans
{
    public class ClassGoalsServiceImpl : IClassGoalsService
    {
        private IClassGoalsDAO _classGoalsDAO;

        public ClassGoalsServiceImpl(IClassGoalsDAO classGoalsDAO)
        {
            _classGoalsDAO = classGoalsDAO;
        }

        public void DeleteClassGoals(ClassGoals classGoals)
        {
            _classGoalsDAO.DeleteClassGoals(classGoals);
        }

        public ClassGoals FindClassGoals(long classGoalsId)
        {
            return _classGoalsDAO.FindClassGoals(classGoalsId);
        }

        public async Task<ClassGoals> FindClassGoalsAsync(long classGoalsId)
        {
            return await _classGoalsDAO.FindClassGoalsAsync(classGoalsId);
        }

        public void InsertClassGoals(ClassGoals newClassGoals)
        {
            _classGoalsDAO.InsertClassGoals(newClassGoals);
        }

        public void UpdateClassGoals(ClassGoals classGoals)
        {
            _classGoalsDAO.UpdateClassGoals(classGoals);
        }
    }
}
