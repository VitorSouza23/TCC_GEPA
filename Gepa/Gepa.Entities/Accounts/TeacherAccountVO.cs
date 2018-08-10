using Gepa.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Entities.Accounts
{
    public class TeacherAccountVO : AccountVO
    {
        public TeacherVO Teacher { get; set; }
        public bool IsCalendarsModuleActived { get; set; }
        public bool IsSchoolClassesModuleActived { get; set; }
    }
}
