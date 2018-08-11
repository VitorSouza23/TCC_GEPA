using Gepa.Entities.ClassPlans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.DAO.ClassPlans
{
    public interface IClassGoalsDAO
    {
        void InsertClassGoals(ClassGoalsVO newClassGoals);
        void UpdateClassGoals(ClassGoalsVO classGoals);
        void DeleteClassGoals(ClassGoalsVO classGoals);
        ClassGoalsVO FindClassGoals(long classGoalsId);
    }
}
