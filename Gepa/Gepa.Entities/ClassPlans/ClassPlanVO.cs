using Gepa.Entities.SchoolClasses;
using Gepa.Entities.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Entities.ClassPlans
{
    public class ClassPlanVO : AbstractVOObject
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Methodology { get; set; }
        public string Observation { get; set; }
        public DateTime Date { get; set; }
        public List<ClassGoalsVO> ClassGoalsList { get; set; }
        public List<EvaluationVO> EvaluationsList { get; set; }
        public List<ChoresVO> ChoresList { get; set; }
        public List<LessonContentVO> LessonContentsList { get; set; }
        public SchoolClassVO SchoolClass { get; set; }
    }
}
