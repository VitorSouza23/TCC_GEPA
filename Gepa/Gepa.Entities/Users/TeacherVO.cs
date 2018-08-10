using Gepa.Entities.Calendar;
using Gepa.Entities.SchoolClasses;
using Gepa.Entities.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Entities.Users
{
    public class TeacherVO : AbstractVOObject
    {
        public string Name { get; set; }
        public List<SchoolClassVO> SchoolClassesList { get; set; }
        public List<SchoolCalendarVO> SchoolCalendarsList { get; set; }
    }
}
