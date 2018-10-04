namespace Gepa.Entities.Framework.Entities.ClassPlans
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("LessonsContent")]
    public partial class LessonsContent
    {
        public long LessonsContentId { get; set; }

        public string ContentValue { get; set; }

        public long ClassPlanId { get; set; }

        public ClassPlan ClassPlan { get; set; }
    }
}
