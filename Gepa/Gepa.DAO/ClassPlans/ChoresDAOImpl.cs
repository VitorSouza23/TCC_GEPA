using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.Entities.Framework;
using Gepa.Entities.Framework.Entities.ClassPlans;

namespace Gepa.DAO.ClassPlans
{
    public class ChoresDAOImpl : AbstractDAO, IChoresDAO
    {
        public ChoresDAOImpl(DbConnection dbConnectioOject) : base(dbConnectioOject)
        {
        }

        public void DeleteChores(Chores chores)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.Chores.Remove(chores);
                em.SaveChanges();
            }
        }

        public Chores FindChores(long choresId)
        {
            Chores chores = null;
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                chores = em.Chores.Find(choresId);
            }
            return chores;
        }

        public async Task<Chores> FindChoresAsync(long choresId)
        {
            Chores chores = null;
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                chores = await em.Chores.FindAsync(choresId);
            }
            return chores;
        }

        public void InsertChores(Chores newChores)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.Chores.Add(newChores);
                em.SaveChanges();
            }
        }

        public void UpdateChores(Chores chores)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.Entry(chores).State = System.Data.Entity.EntityState.Modified;
                em.SaveChanges();
            }
        }
    }
}
