using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.DAO.Calendar;
using Gepa.Entities.Framework.Entities.Calendar;

namespace Gepa.Business.Calendar
{
    public class AbstractSchoolEventServiceImpl : IAbstractSchoolEventService
    {
        private IAbstractSchoolEventDAO _abstractSchoolEventDAO;

        public AbstractSchoolEventServiceImpl(IAbstractSchoolEventDAO abstractSchoolEventDAO)
        {
            _abstractSchoolEventDAO = abstractSchoolEventDAO;
        }

        public void DeleteAbstractSchoolEvent(AbstractSchoolEvent abstractSchoolEvent)
        {
            _abstractSchoolEventDAO.DeleteAbstractSchoolEvent(abstractSchoolEvent);
        }

        public AbstractSchoolEvent FindAbstractShoolEvent(long abstractSchoolEventId)
        {
            return _abstractSchoolEventDAO.FindAbstractShoolEvent(abstractSchoolEventId);
        }

        public async Task<AbstractSchoolEvent> FindAbstractShoolEventAsnyc(long abstractSchoolEventId)
        {
            return await _abstractSchoolEventDAO.FindAbstractShoolEventAsync(abstractSchoolEventId);
        }

        public void InsertAbstractSchoolEvent(AbstractSchoolEvent newAbstractSchoolEvent)
        {
            _abstractSchoolEventDAO.InsertAbstractSchoolEvent(newAbstractSchoolEvent);
        }

        public void UpdateAbstractSchoolEvent(AbstractSchoolEvent abstractSchoolEvent)
        {
            _abstractSchoolEventDAO.UpdateAbstractSchoolEvent(abstractSchoolEvent);
        }
    }
}
