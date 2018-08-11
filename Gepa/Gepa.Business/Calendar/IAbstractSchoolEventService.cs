using Gepa.Entities.Calendar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Business.Calendar
{
    public interface IAbstractSchoolEventService
    {
        void InsertAbstractSchoolEvent(AbstractSchoolEventVO newAbstractSchoolEvent);
        void UpdateAbstractSchoolEvent(AbstractSchoolEventVO abstractSchoolEvent);
        void DeleteAbstractSchoolEvent(AbstractSchoolEventVO abstractSchoolEvent);
        AbstractSchoolEventVO FindAbstractShoolEvent(long abstractSchoolEventId);
    }
}
