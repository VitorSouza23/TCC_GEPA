namespace Gepa.Entities.Framework.Entities.ClassPlans
{
    public partial class ClassGoals
    {
        public long ClassGoalsId { get; set; }

        public string Objective { get; set; }

        public bool IsCompleted { get; set; }

        public long ClassPlanId { get; set; }

        public ClassPlan ClassPlan { get; set; }
    }
}
