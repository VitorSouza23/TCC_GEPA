using Gepa.Entities.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Entities.SchoolClasses
{
    public class ClassDiaryVO : AbstractVOObject
    {
        public string Observation { get; set; }
        public List<StudentNoteVO> StudentsNotesList { get; set; }
    }
}
