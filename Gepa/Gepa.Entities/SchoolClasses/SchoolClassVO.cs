using Gepa.Entities.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Entities.SchoolClasses
{
    public class SchoolClassVO : AbstractVOObject
    {
        public string Name { get; set; }
        public string SchoolName { get; set; }
        public string Observation { get; set; }
        public ClassDiaryVO ClassDiary { get; set; }
        public List<StudentVO> StudentsList { get; set; }
        public ClassFrequencyVO ClassFrequency { get; set; }
    }
}
