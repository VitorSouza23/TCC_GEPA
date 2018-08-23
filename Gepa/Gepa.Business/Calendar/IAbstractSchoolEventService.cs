using Gepa.Entities.Framework.Entities.Calendar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Business.Calendar
{
    public interface IAbstractSchoolEventService : IGepaService
    {
        void InsertAbstractSchoolEvent(AbstractSchoolEvent newAbstractSchoolEvent);
        void UpdateAbstractSchoolEvent(AbstractSchoolEvent abstractSchoolEvent);
        void DeleteAbstractSchoolEvent(AbstractSchoolEvent abstractSchoolEvent);
        AbstractSchoolEvent FindAbstractShoolEvent(long abstractSchoolEventId);
    }
}
