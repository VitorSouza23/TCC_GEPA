namespace Gepa.Entities.Framework.Entities.Users
{
    using Gepa.Entities.Framework.Entities.Calendar;
    using Gepa.Entities.Framework.Entities.ClassPlans;
    using Gepa.Entities.Framework.Entities.SchoolClasses;
    using Gepa.Entities.Framework.Utils;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Teacher")]
    public partial class Teacher
    {
        public Teacher()
        {
            ClassPlan = new List<ClassPlan>();
            School = new List<School>();
            SchoolCalendar = new List<SchoolCalendar>();
        }

        public long TeacherId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public CultureLanguageEnum CultureLanguage { get; set; }

        public List<ClassPlan> ClassPlan { get; set; }

        public List<School> School { get; set; }

        public List<SchoolCalendar> SchoolCalendar { get; set; }

        public string UserId { get; set; }
    }
}
