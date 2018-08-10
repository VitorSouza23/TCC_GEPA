using Gepa.Entities.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Entities.SchoolClasses
{
    public class ClassFrequencyVO : AbstractVOObject
    {
        public DateTime Date { get; set; }
        public List<StudentPresenceVO> StudentPresencesList { get; set; }
    }
}
