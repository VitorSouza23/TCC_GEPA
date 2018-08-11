using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.DAO.Calendar;
using Gepa.Entities.Calendar;

namespace Gepa.Business.Calendar
{
    public class AbstractSchoolEventServiceImpl : IAbstractSchoolEventService
    {
        private IAbstractSchoolEventDAO _abstractSchoolEventDAO;

        public AbstractSchoolEventServiceImpl(IAbstractSchoolEventDAO abstractSchoolEventDAO)
        {
            _abstractSchoolEventDAO = abstractSchoolEventDAO;
        }

        public void DeleteAbstractSchoolEvent(AbstractSchoolEventVO abstractSchoolEvent)
        {
            _abstractSchoolEventDAO.DeleteAbstractSchoolEvent(abstractSchoolEvent);
        }

        public AbstractSchoolEventVO FindAbstractShoolEvent(long abstractSchoolEventId)
        {
            return _abstractSchoolEventDAO.FindAbstractShoolEvent(abstractSchoolEventId);
        }

        public void InsertAbstractSchoolEvent(AbstractSchoolEventVO newAbstractSchoolEvent)
        {
            _abstractSchoolEventDAO.InsertAbstractSchoolEvent(newAbstractSchoolEvent);
        }

        public void UpdateAbstractSchoolEvent(AbstractSchoolEventVO abstractSchoolEvent)
        {
            _abstractSchoolEventDAO.UpdateAbstractSchoolEvent(abstractSchoolEvent);
        }
    }
}
