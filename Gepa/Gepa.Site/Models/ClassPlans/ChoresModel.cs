using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gepa.Site.Models.ClassPlans
{
    public class ChoresModel
    {
        public long Id { get; set; }
        public string Task { get; set; }
        public bool Completed { get; set; }
    }
}