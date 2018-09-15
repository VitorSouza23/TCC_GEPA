using Gepa.Entities.Framework.Entities.ClassPlans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.DAO.ClassPlans
{
    public interface IChoresDAO
    {
        void InsertChores(Chores newChores);
        void UpdateChores(Chores chores);
        void DeleteChores(Chores chores);
        Chores FindChores(long choresId);
        Task<Chores> FindChoresAsync(long choresId);
    }
}
