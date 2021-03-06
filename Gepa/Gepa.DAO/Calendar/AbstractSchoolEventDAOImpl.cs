﻿using Gepa.Entities.Framework;
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

        public AbstractSchoolEventDAOImpl() : base()
        {
        }

        public void DeleteAbstractSchoolEvent(AbstractSchoolEvent abstractSchoolEvent)
        {
            using (EntityModel em = new EntityModel())
            {
                em.AbstractSchoolEvent.Remove(abstractSchoolEvent);
                em.SaveChanges();
            }
        }

        public AbstractSchoolEvent FindAbstractShoolEvent(long abstractSchoolEventId)
        {
            AbstractSchoolEvent abstractSchoolEvent = null;
            using(EntityModel em = new EntityModel())
            {
                abstractSchoolEvent = em.AbstractSchoolEvent.Find(abstractSchoolEventId);
            }
            return abstractSchoolEvent;
        }

        public async Task<AbstractSchoolEvent> FindAbstractShoolEventAsync(long abstractSchoolEventId)
        {
            AbstractSchoolEvent abstractSchoolEvent = null;
            using (EntityModel em = new EntityModel())
            {
                abstractSchoolEvent = await em.AbstractSchoolEvent.FindAsync(abstractSchoolEventId);
            }
            return abstractSchoolEvent;
        }

        public void InsertAbstractSchoolEvent(AbstractSchoolEvent newAbstractSchoolEvent)
        {
            using (EntityModel em = new EntityModel())
            {
                em.AbstractSchoolEvent.Add(newAbstractSchoolEvent);
                em.SaveChanges();
            }
        }

        public void UpdateAbstractSchoolEvent(AbstractSchoolEvent abstractSchoolEvent)
        {
            using (EntityModel em = new EntityModel())
            {
                em.Entry(abstractSchoolEvent).State = System.Data.Entity.EntityState.Modified;
                em.SaveChanges();
            }
        }
    }
}
