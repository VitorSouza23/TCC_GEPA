using Gepa.Entities.ClassPlans;
using Gepa.Entities.SchoolClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Entities.Calendar
{
    public class ClassScheduleVO : AbstractSchoolEventVO
    {
        public ClassPlanVO ClassPlan { get; set; }
        public SchoolClassVO SchoolClass { get; set; }
    }
}
