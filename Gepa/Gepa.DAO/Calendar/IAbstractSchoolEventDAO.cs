using Gepa.Entities.Calendar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.DAO.Calendar
{
    public interface IAbstractSchoolEventDAO
    {
        void InsertAbstractSchoolEvent(AbstractSchoolEventVO newAbstractSchoolEvent);
        void UpdateAbstractSchoolEvent(AbstractSchoolEventVO abstractSchoolEvent);
        void DeleteAbstractSchoolEvent(AbstractSchoolEventVO abstractSchoolEvent);
        AbstractSchoolEventVO FindAbstractShoolEvent(long abstractSchoolEventId);
    }
}
