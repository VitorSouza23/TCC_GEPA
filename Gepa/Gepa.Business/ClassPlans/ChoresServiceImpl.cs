using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.DAO.ClassPlans;
using Gepa.Entities.Framework.Entities.ClassPlans;

namespace Gepa.Business.ClassPlans
{
    public class ChoresServiceImpl : IChoresService
    {
        private IChoresDAO _choresDAO;

        public ChoresServiceImpl(IChoresDAO choresDAO)
        {
            _choresDAO = choresDAO;
        }

        public void DeleteChores(Chores chores)
        {
            _choresDAO.DeleteChores(chores);
        }

        public Chores FindChores(long choresId)
        {
            return _choresDAO.FindChores(choresId);
        }

        public async Task<Chores> FindChoresAsync(long choresId)
        {
            return await _choresDAO.FindChoresAsync(choresId);
        }

        public void InsertChores(Chores newChores)
        {
            _choresDAO.InsertChores(newChores);
        }

        public void UpdateChores(Chores chores)
        {
            _choresDAO.UpdateChores(chores);
        }
    }
}
