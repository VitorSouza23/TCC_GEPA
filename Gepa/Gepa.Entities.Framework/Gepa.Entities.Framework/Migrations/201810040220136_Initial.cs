namespace Gepa.Entities.Framework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AbstractSchoolEvent",
                c => new
                    {
                        AbstractSchoolEventId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Observation = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        SchoolCalendarId = c.Long(nullable: false),
                        Discriminator = c.String(maxLength: 128),
                        SchoolCalendar_SchoolCalendarId = c.Long(),
                    })
                .PrimaryKey(t => t.AbstractSchoolEventId)
                .ForeignKey("dbo.SchoolCalendar", t => t.SchoolCalendar_SchoolCalendarId)
                .ForeignKey("dbo.SchoolCalendar", t => t.SchoolCalendarId, cascadeDelete: true)
                .Index(t => t.SchoolCalendarId)
                .Index(t => t.SchoolCalendar_SchoolCalendarId);
            
            CreateTable(
                "dbo.SchoolCalendar",
                c => new
                    {
                        SchoolCalendarId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Observation = c.String(),
                        TeacherId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.SchoolCalendarId)
                .ForeignKey("dbo.Teacher", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.TeacherId);
            
            CreateTable(
                "dbo.Teacher",
                c => new
                    {
                        TeacherId = c.Long(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        CultureLanguage = c.Int(nullable: false),
                        UserId = c.String(),
                    })
                .PrimaryKey(t => t.TeacherId);
            
            CreateTable(
                "dbo.ClassPlan",
                c => new
                    {
                        ClassPlanId = c.Long(nullable: false, identity: true),
                        Date = c.DateTime(),
                        Methodology = c.String(),
                        Title = c.String(nullable: false, maxLength: 50),
                        Observation = c.String(),
                        Description = c.String(),
                        TeacherId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ClassPlanId)
                .ForeignKey("dbo.Teacher", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.TeacherId);
            
            CreateTable(
                "dbo.Chores",
                c => new
                    {
                        ChoresId = c.Long(nullable: false, identity: true),
                        Task = c.String(),
                        Completed = c.Boolean(nullable: false),
                        ClassPlanId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ChoresId)
                .ForeignKey("dbo.ClassPlan", t => t.ClassPlanId, cascadeDelete: true)
                .Index(t => t.ClassPlanId);
            
            CreateTable(
                "dbo.ClassGoals",
                c => new
                    {
                        ClassGoalsId = c.Long(nullable: false, identity: true),
                        Objective = c.String(),
                        IsCompleted = c.Boolean(nullable: false),
                        ClassPlanId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ClassGoalsId)
                .ForeignKey("dbo.ClassPlan", t => t.ClassPlanId, cascadeDelete: true)
                .Index(t => t.ClassPlanId);
            
            CreateTable(
                "dbo.Evaluetion",
                c => new
                    {
                        EvaluetionId = c.Long(nullable: false, identity: true),
                        Description = c.String(),
                        ClassPlanId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.EvaluetionId)
                .ForeignKey("dbo.ClassPlan", t => t.ClassPlanId, cascadeDelete: true)
                .Index(t => t.ClassPlanId);
            
            CreateTable(
                "dbo.StudentNote",
                c => new
                    {
                        StudentNoteId = c.Long(nullable: false, identity: true),
                        QuantitativeGrade = c.Decimal(precision: 18, scale: 2, storeType: "numeric"),
                        QualitativeNote = c.String(maxLength: 10),
                        Observation = c.String(),
                        StudentId = c.Long(nullable: false),
                        ClassDiary_ClassDiaryId = c.Long(),
                        Evaluetion_EvaluetionId = c.Long(),
                    })
                .PrimaryKey(t => t.StudentNoteId)
                .ForeignKey("dbo.ClassDiary", t => t.ClassDiary_ClassDiaryId)
                .ForeignKey("dbo.Student", t => t.StudentId, cascadeDelete: true)
                .ForeignKey("dbo.Evaluetion", t => t.Evaluetion_EvaluetionId)
                .Index(t => t.StudentId)
                .Index(t => t.ClassDiary_ClassDiaryId)
                .Index(t => t.Evaluetion_EvaluetionId);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        StudentId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        Observation = c.String(),
                        SchoolClassId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.SchoolClass", t => t.SchoolClassId, cascadeDelete: true)
                .Index(t => t.SchoolClassId);
            
            CreateTable(
                "dbo.SchoolClass",
                c => new
                    {
                        SchoolClassId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Observation = c.String(),
                        SchoolId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.SchoolClassId)
                .ForeignKey("dbo.School", t => t.SchoolId, cascadeDelete: true)
                .Index(t => t.SchoolId);
            
            CreateTable(
                "dbo.ClassDiary",
                c => new
                    {
                        ClassDiaryId = c.Long(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        SchoolClassId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ClassDiaryId)
                .ForeignKey("dbo.SchoolClass", t => t.SchoolClassId, cascadeDelete: true)
                .Index(t => t.SchoolClassId);
            
            CreateTable(
                "dbo.ClassFrequency",
                c => new
                    {
                        ClassFrequencyId = c.Long(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        SchoolClassId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ClassFrequencyId)
                .ForeignKey("dbo.SchoolClass", t => t.SchoolClassId, cascadeDelete: true)
                .Index(t => t.SchoolClassId);
            
            CreateTable(
                "dbo.StudentPresence",
                c => new
                    {
                        StudentPresenceId = c.Long(nullable: false, identity: true),
                        Observation = c.String(),
                        PesenceStatus = c.Int(nullable: false),
                        StudentId = c.Long(nullable: false),
                        ClassFrequency_ClassFrequencyId = c.Long(),
                    })
                .PrimaryKey(t => t.StudentPresenceId)
                .ForeignKey("dbo.Student", t => t.StudentId, cascadeDelete: true)
                .ForeignKey("dbo.ClassFrequency", t => t.ClassFrequency_ClassFrequencyId)
                .Index(t => t.StudentId)
                .Index(t => t.ClassFrequency_ClassFrequencyId);
            
            CreateTable(
                "dbo.School",
                c => new
                    {
                        SchoolId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        TeacherId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.SchoolId)
                .ForeignKey("dbo.Teacher", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.TeacherId);
            
            CreateTable(
                "dbo.LessonsContent",
                c => new
                    {
                        LessonsContentId = c.Long(nullable: false, identity: true),
                        ContentValue = c.String(),
                        ClassPlanId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.LessonsContentId)
                .ForeignKey("dbo.ClassPlan", t => t.ClassPlanId, cascadeDelete: true)
                .Index(t => t.ClassPlanId);
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
            CreateTable(
                "dbo.SchoolEvent",
                c => new
                    {
                        AbstractSchoolEventId = c.Long(nullable: false),
                        SchoolCalendar_SchoolCalendarId = c.Long(),
                    })
                .PrimaryKey(t => t.AbstractSchoolEventId)
                .ForeignKey("dbo.AbstractSchoolEvent", t => t.AbstractSchoolEventId)
                .ForeignKey("dbo.SchoolCalendar", t => t.SchoolCalendar_SchoolCalendarId)
                .Index(t => t.AbstractSchoolEventId)
                .Index(t => t.SchoolCalendar_SchoolCalendarId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SchoolEvent", "SchoolCalendar_SchoolCalendarId", "dbo.SchoolCalendar");
            DropForeignKey("dbo.SchoolEvent", "AbstractSchoolEventId", "dbo.AbstractSchoolEvent");
            DropForeignKey("dbo.AbstractSchoolEvent", "SchoolCalendarId", "dbo.SchoolCalendar");
            DropForeignKey("dbo.SchoolCalendar", "TeacherId", "dbo.Teacher");
            DropForeignKey("dbo.ClassPlan", "TeacherId", "dbo.Teacher");
            DropForeignKey("dbo.LessonsContent", "ClassPlanId", "dbo.ClassPlan");
            DropForeignKey("dbo.StudentNote", "Evaluetion_EvaluetionId", "dbo.Evaluetion");
            DropForeignKey("dbo.StudentNote", "StudentId", "dbo.Student");
            DropForeignKey("dbo.Student", "SchoolClassId", "dbo.SchoolClass");
            DropForeignKey("dbo.SchoolClass", "SchoolId", "dbo.School");
            DropForeignKey("dbo.School", "TeacherId", "dbo.Teacher");
            DropForeignKey("dbo.StudentPresence", "ClassFrequency_ClassFrequencyId", "dbo.ClassFrequency");
            DropForeignKey("dbo.StudentPresence", "StudentId", "dbo.Student");
            DropForeignKey("dbo.ClassFrequency", "SchoolClassId", "dbo.SchoolClass");
            DropForeignKey("dbo.StudentNote", "ClassDiary_ClassDiaryId", "dbo.ClassDiary");
            DropForeignKey("dbo.ClassDiary", "SchoolClassId", "dbo.SchoolClass");
            DropForeignKey("dbo.Evaluetion", "ClassPlanId", "dbo.ClassPlan");
            DropForeignKey("dbo.ClassGoals", "ClassPlanId", "dbo.ClassPlan");
            DropForeignKey("dbo.Chores", "ClassPlanId", "dbo.ClassPlan");
            DropForeignKey("dbo.AbstractSchoolEvent", "SchoolCalendar_SchoolCalendarId", "dbo.SchoolCalendar");
            DropIndex("dbo.SchoolEvent", new[] { "SchoolCalendar_SchoolCalendarId" });
            DropIndex("dbo.SchoolEvent", new[] { "AbstractSchoolEventId" });
            DropIndex("dbo.LessonsContent", new[] { "ClassPlanId" });
            DropIndex("dbo.School", new[] { "TeacherId" });
            DropIndex("dbo.StudentPresence", new[] { "ClassFrequency_ClassFrequencyId" });
            DropIndex("dbo.StudentPresence", new[] { "StudentId" });
            DropIndex("dbo.ClassFrequency", new[] { "SchoolClassId" });
            DropIndex("dbo.ClassDiary", new[] { "SchoolClassId" });
            DropIndex("dbo.SchoolClass", new[] { "SchoolId" });
            DropIndex("dbo.Student", new[] { "SchoolClassId" });
            DropIndex("dbo.StudentNote", new[] { "Evaluetion_EvaluetionId" });
            DropIndex("dbo.StudentNote", new[] { "ClassDiary_ClassDiaryId" });
            DropIndex("dbo.StudentNote", new[] { "StudentId" });
            DropIndex("dbo.Evaluetion", new[] { "ClassPlanId" });
            DropIndex("dbo.ClassGoals", new[] { "ClassPlanId" });
            DropIndex("dbo.Chores", new[] { "ClassPlanId" });
            DropIndex("dbo.ClassPlan", new[] { "TeacherId" });
            DropIndex("dbo.SchoolCalendar", new[] { "TeacherId" });
            DropIndex("dbo.AbstractSchoolEvent", new[] { "SchoolCalendar_SchoolCalendarId" });
            DropIndex("dbo.AbstractSchoolEvent", new[] { "SchoolCalendarId" });
            DropTable("dbo.SchoolEvent");
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.LessonsContent");
            DropTable("dbo.School");
            DropTable("dbo.StudentPresence");
            DropTable("dbo.ClassFrequency");
            DropTable("dbo.ClassDiary");
            DropTable("dbo.SchoolClass");
            DropTable("dbo.Student");
            DropTable("dbo.StudentNote");
            DropTable("dbo.Evaluetion");
            DropTable("dbo.ClassGoals");
            DropTable("dbo.Chores");
            DropTable("dbo.ClassPlan");
            DropTable("dbo.Teacher");
            DropTable("dbo.SchoolCalendar");
            DropTable("dbo.AbstractSchoolEvent");
        }
    }
}
