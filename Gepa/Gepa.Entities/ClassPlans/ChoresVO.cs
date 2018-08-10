using Gepa.Entities.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Entities.ClassPlans
{
    public class ChoresVO : AbstractVOObject
    {
        public string Task { get; set; }
        public bool Completed { get; set; }
    }
}
