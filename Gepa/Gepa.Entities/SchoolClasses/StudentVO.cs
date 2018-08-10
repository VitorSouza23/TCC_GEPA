using Gepa.Entities.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Entities.SchoolClasses
{
    public class StudentVO : AbstractVOObject
    {
        public string Name { get; set; }
        public string Observation { get; set; }
    }
}
