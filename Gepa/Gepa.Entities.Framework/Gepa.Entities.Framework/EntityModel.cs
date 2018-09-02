namespace Gepa.Entities.Framework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Gepa.Entities.Framework.Mappings.Calendar;
    using Gepa.Entities.Framework.Entities.Calendar;
    using Gepa.Entities.Framework.Mappings.ClassPlans;
    using Gepa.Entities.Framework.Entities.ClassPlans;
    using Gepa.Entities.Framework.Mappings.SchoolClasses;
    using Gepa.Entities.Framework.Entities.SchoolClasses;
    using Gepa.Entities.Framework.Mappings.Users;
    using Gepa.Entities.Framework.Entities.Users;
    using System.Data.Common;

    public partial class EntityModel : DbContext
    {
        public EntityModel(DbConnection dbConnection)
            : base(dbConnection, false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EntityModel, MigrationsConfig>());
        }

        public EntityModel() :base("name=EntityModel")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EntityModel, MigrationsConfig>());
        }

        public virtual DbSet<AbstractSchoolEvent> AbstractSchoolEvent { get; set; }
        public virtual DbSet<Chores> Chores { get; set; }
        public virtual DbSet<ClassDiary> ClassDiary { get; set; }
        public virtual DbSet<ClassFrequency> ClassFrequency { get; set; }
        public virtual DbSet<ClassGoals> ClassGoals { get; set; }
        public virtual DbSet<ClassPlan> ClassPlan { get; set; }
        public virtual DbSet<Evaluetion> Evaluetion { get; set; }
        public virtual DbSet<LessonsContent> LessonsContent { get; set; }
        public virtual DbSet<School> School { get; set; }
        public virtual DbSet<SchoolCalendar> SchoolCalendar { get; set; }
        public virtual DbSet<SchoolClass> SchoolClass { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentNote> StudentNote { get; set; }
        public virtual DbSet<StudentPresence> StudentPresence { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AbstractSchoolEventMap());
            modelBuilder.Configurations.Add(new ClassScheduleMap());
            modelBuilder.Configurations.Add(new SchoolCalendarMap());
            modelBuilder.Configurations.Add(new SchoolEventMap());
            modelBuilder.Configurations.Add(new ChoresMap());
            modelBuilder.Configurations.Add(new ClassGoalsMap());
            modelBuilder.Configurations.Add(new ClassPlanMap());
            modelBuilder.Configurations.Add(new EvaluetionMap());
            modelBuilder.Configurations.Add(new LessonsContentMap());
            modelBuilder.Configurations.Add(new ClassDiaryMap());
            modelBuilder.Configurations.Add(new ClassFrequencyMap());
            modelBuilder.Configurations.Add(new SchoolMap());
            modelBuilder.Configurations.Add(new SchoolClassMap());
            modelBuilder.Configurations.Add(new StudentMap());
            modelBuilder.Configurations.Add(new StudentNoteMap());
            modelBuilder.Configurations.Add(new StudentPresenceMap());
            modelBuilder.Configurations.Add(new TeacherMap());
        }
    }
}
