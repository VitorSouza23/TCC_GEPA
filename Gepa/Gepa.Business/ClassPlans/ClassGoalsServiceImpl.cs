using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.DAO.ClassPlans;
using Gepa.Entities.ClassPlans;

namespace Gepa.Business.ClassPlans
{
    public class ClassGoalsServiceImpl : IClassGoalsService
    {
        private IClassGoalsDAO _classGoalsDAO;

        public ClassGoalsServiceImpl(IClassGoalsDAO classGoalsDAO)
        {
            _classGoalsDAO = classGoalsDAO;
        }

        public void DeleteClassGoals(ClassGoalsVO classGoals)
        {
            _classGoalsDAO.DeleteClassGoals(classGoals);
        }

        public ClassGoalsVO FindClassGoals(long classGoalsId)
        {
            return _classGoalsDAO.FindClassGoals(classGoalsId);
        }

        public void InsertClassGoals(ClassGoalsVO newClassGoals)
        {
            _classGoalsDAO.InsertClassGoals(newClassGoals);
        }

        public void UpdateClassGoals(ClassGoalsVO classGoals)
        {
            _classGoalsDAO.UpdateClassGoals(classGoals);
        }
    }
}
