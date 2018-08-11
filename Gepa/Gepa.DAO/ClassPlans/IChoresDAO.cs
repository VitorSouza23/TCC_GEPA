using Gepa.Entities.ClassPlans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.DAO.ClassPlans
{
    public interface IChoresDAO
    {
        void InsertChores(ChoresVO newChores);
        void UpdateChores(ChoresVO chores);
        void DeleteChores(ChoresVO chores);
        ChoresVO FindChores(long choresId);
    }
}
