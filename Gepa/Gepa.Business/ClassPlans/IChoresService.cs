using Gepa.Entities.ClassPlans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Business.ClassPlans
{
    public interface IChoresService
    {
        void InsertChores(ChoresVO newChores);
        void UpdateChores(ChoresVO chores);
        void DeleteChores(ChoresVO chores);
        ChoresVO FindChores(long choresId);
    }
}
