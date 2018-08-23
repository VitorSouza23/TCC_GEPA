using Gepa.Entities.Framework;
using Gepa.Entities.Framework.Entities.Calendar;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.DAO.Calendar
{
    public class AbstractSchoolEventDAOImpl : AbstractDAO, IAbstractSchoolEventDAO
    {

        public AbstractSchoolEventDAOImpl(DbConnection dbConnection) : base(dbConnection)
        {
        }

        public void DeleteAbstractSchoolEvent(AbstractSchoolEvent abstractSchoolEvent)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.AbstractSchoolEvent.Remove(abstractSchoolEvent);
                em.SaveChanges();
            }
        }

        public AbstractSchoolEvent FindAbstractShoolEvent(long abstractSchoolEventId)
        {
            AbstractSchoolEvent abstractSchoolEvent = null;
            using(EntityModel em = new EntityModel(DbConnectioOject))
            {
                abstractSchoolEvent = em.AbstractSchoolEvent.Single(a => a.AbstractSchoolEventId == abstractSchoolEventId);
            }
            return abstractSchoolEvent;
        }

        public void InsertAbstractSchoolEvent(AbstractSchoolEvent newAbstractSchoolEvent)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.AbstractSchoolEvent.Add(newAbstractSchoolEvent);
                em.SaveChanges();
            }
        }

        public void UpdateAbstractSchoolEvent(AbstractSchoolEvent abstractSchoolEvent)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.Entry(abstractSchoolEvent).State = System.Data.Entity.EntityState.Modified;
                em.SaveChanges();
            }
        }
    }
}
