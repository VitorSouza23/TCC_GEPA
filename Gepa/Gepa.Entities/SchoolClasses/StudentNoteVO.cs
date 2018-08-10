using Gepa.Entities.ClassPlans;
using Gepa.Entities.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Entities.SchoolClasses
{
    public class StudentNoteVO : AbstractVOObject
    {
        public float QuantitativeGrade { get; set; }
        public string QualitativeNote { get; set; }
        public string Observation { get; set; }
        public StudentVO Student { get; set; }
        public EvaluationVO Evaluation { get; set; }
    }
}
