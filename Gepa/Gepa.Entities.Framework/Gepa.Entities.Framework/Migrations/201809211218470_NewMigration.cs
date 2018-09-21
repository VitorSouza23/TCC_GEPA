namespace Gepa.Entities.Framework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewMigration : DbMigration
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
                    })
                .PrimaryKey(t => t.AbstractSchoolEventId);
            
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
                        Teacher_TeacherId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ClassPlanId)
                .ForeignKey("dbo.Teacher", t => t.Teacher_TeacherId)
                .Index(t => t.Teacher_TeacherId);
            
            CreateTable(
                "dbo.Chores",
                c => new
                    {
                        ChoresId = c.Long(nullable: false, identity: true),
                        Task = c.String(),
                        Completed = c.Boolean(nullable: false),
                        ClassPlan_ClassPlanId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ChoresId)
                .ForeignKey("dbo.ClassPlan", t => t.ClassPlan_ClassPlanId)
                .Index(t => t.ClassPlan_ClassPlanId);
            
            CreateTable(
                "dbo.ClassGoals",
                c => new
                    {
                        ClassGoalsId = c.Long(nullable: false, identity: true),
                        Objective = c.String(),
                        ClassPlan_ClassPlanId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ClassGoalsId)
                .ForeignKey("dbo.ClassPlan", t => t.ClassPlan_ClassPlanId)
                .Index(t => t.ClassPlan_ClassPlanId);
            
            CreateTable(
                "dbo.Evaluetion",
                c => new
                    {
                        EvaluetionId = c.Long(nullable: false),
                        Description = c.String(),
                        ClassPlan_ClassPlanId = c.Long(),
                    })
                .PrimaryKey(t => t.EvaluetionId)
                .ForeignKey("dbo.ClassPlan", t => t.ClassPlan_ClassPlanId)
                .Index(t => t.ClassPlan_ClassPlanId);
            
            CreateTable(
                "dbo.StudentNote",
                c => new
                    {
                        StudentNoteId = c.Long(nullable: false, identity: true),
                        QuantitativeGrade = c.Decimal(precision: 18, scale: 2, storeType: "numeric"),
                        QualitativeNote = c.String(maxLength: 10),
                        Observation = c.String(),
                        Student_StudentId = c.Long(nullable: false),
                        ClassDiary_ClassDiaryId = c.Long(nullable: false),
                        Evaluetion_EvaluetionId = c.Long(),
                    })
                .PrimaryKey(t => t.StudentNoteId)
                .ForeignKey("dbo.Student", t => t.Student_StudentId)
                .ForeignKey("dbo.ClassDiary", t => t.ClassDiary_ClassDiaryId)
                .ForeignKey("dbo.Evaluetion", t => t.Evaluetion_EvaluetionId)
                .Index(t => t.Student_StudentId)
                .Index(t => t.ClassDiary_ClassDiaryId)
                .Index(t => t.Evaluetion_EvaluetionId);
            
            CreateTable(
                "dbo.ClassDiary",
                c => new
                    {
                        ClassDiaryId = c.Long(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        SchoolClass_SchoolClassId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ClassDiaryId)
                .ForeignKey("dbo.SchoolClass", t => t.SchoolClass_SchoolClassId)
                .Index(t => t.SchoolClass_SchoolClassId);
            
            CreateTable(
                "dbo.SchoolClass",
                c => new
                    {
                        SchoolClassId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Observation = c.String(),
                        School_SchoolId = c.Long(nullable: false),
                        Teacher_TeacherId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.SchoolClassId)
                .ForeignKey("dbo.School", t => t.School_SchoolId)
                .ForeignKey("dbo.Teacher", t => t.Teacher_TeacherId)
                .Index(t => t.School_SchoolId)
                .Index(t => t.Teacher_TeacherId);
            
            CreateTable(
                "dbo.ClassFrequency",
                c => new
                    {
                        ClassFrequencyId = c.Long(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        SchoolClass_SchoolClassId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ClassFrequencyId)
                .ForeignKey("dbo.SchoolClass", t => t.SchoolClass_SchoolClassId)
                .Index(t => t.SchoolClass_SchoolClassId);
            
            CreateTable(
                "dbo.StudentPresence",
                c => new
                    {
                        StudentPresenceId = c.Long(nullable: false, identity: true),
                        Observation = c.String(),
                        PesenceStatus = c.Int(nullable: false),
                        Student_StudentId = c.Long(nullable: false),
                        ClassFrequency_ClassFrequencyId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.StudentPresenceId)
                .ForeignKey("dbo.Student", t => t.Student_StudentId)
                .ForeignKey("dbo.ClassFrequency", t => t.ClassFrequency_ClassFrequencyId)
                .Index(t => t.Student_StudentId)
                .Index(t => t.ClassFrequency_ClassFrequencyId);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        StudentId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        Observation = c.String(),
                        SchoolClass_SchoolClassId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.SchoolClass", t => t.SchoolClass_SchoolClassId)
                .Index(t => t.SchoolClass_SchoolClassId);
            
            CreateTable(
                "dbo.School",
                c => new
                    {
                        SchoolId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Teacher_TeacherId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.SchoolId)
                .ForeignKey("dbo.Teacher", t => t.Teacher_TeacherId)
                .Index(t => t.Teacher_TeacherId);
            
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
                "dbo.SchoolCalendar",
                c => new
                    {
                        SchoolCalendarId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Observation = c.String(),
                        TeacherID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.SchoolCalendarId)
                .ForeignKey("dbo.Teacher", t => t.TeacherID)
                .Index(t => t.TeacherID);
            
            CreateTable(
                "dbo.LessonsContent",
                c => new
                    {
                        LessonsContentId = c.Long(nullable: false, identity: true),
                        ContentValue = c.String(),
                        ClassPlan_ClassPlanId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.LessonsContentId)
                .ForeignKey("dbo.ClassPlan", t => t.ClassPlan_ClassPlanId)
                .Index(t => t.ClassPlan_ClassPlanId);
            
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
                "dbo.ClassSchedule",
                c => new
                    {
                        AbstractSchoolEventId = c.Long(nullable: false),
                        SchoolCalendar_SchoolCalendarId = c.Long(nullable: false),
                        ClassPlan_ClassPlanId = c.Long(),
                    })
                .PrimaryKey(t => t.AbstractSchoolEventId)
                .ForeignKey("dbo.AbstractSchoolEvent", t => t.AbstractSchoolEventId)
                .ForeignKey("dbo.SchoolCalendar", t => t.SchoolCalendar_SchoolCalendarId)
                .ForeignKey("dbo.ClassPlan", t => t.ClassPlan_ClassPlanId)
                .Index(t => t.AbstractSchoolEventId)
                .Index(t => t.SchoolCalendar_SchoolCalendarId)
                .Index(t => t.ClassPlan_ClassPlanId);
            
            CreateTable(
                "dbo.SchoolEvent",
                c => new
                    {
                        AbstractSchoolEventId = c.Long(nullable: false),
                        SchoolCalendar_SchoolCalendarId = c.Long(nullable: false),
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
            DropForeignKey("dbo.ClassSchedule", "ClassPlan_ClassPlanId", "dbo.ClassPlan");
            DropForeignKey("dbo.ClassSchedule", "SchoolCalendar_SchoolCalendarId", "dbo.SchoolCalendar");
            DropForeignKey("dbo.ClassSchedule", "AbstractSchoolEventId", "dbo.AbstractSchoolEvent");
            DropForeignKey("dbo.LessonsContent", "ClassPlan_ClassPlanId", "dbo.ClassPlan");
            DropForeignKey("dbo.StudentNote", "Evaluetion_EvaluetionId", "dbo.Evaluetion");
            DropForeignKey("dbo.StudentNote", "ClassDiary_ClassDiaryId", "dbo.ClassDiary");
            DropForeignKey("dbo.Student", "SchoolClass_SchoolClassId", "dbo.SchoolClass");
            DropForeignKey("dbo.SchoolClass", "Teacher_TeacherId", "dbo.Teacher");
            DropForeignKey("dbo.SchoolCalendar", "TeacherID", "dbo.Teacher");
            DropForeignKey("dbo.School", "Teacher_TeacherId", "dbo.Teacher");
            DropForeignKey("dbo.ClassPlan", "Teacher_TeacherId", "dbo.Teacher");
            DropForeignKey("dbo.SchoolClass", "School_SchoolId", "dbo.School");
            DropForeignKey("dbo.ClassFrequency", "SchoolClass_SchoolClassId", "dbo.SchoolClass");
            DropForeignKey("dbo.StudentPresence", "ClassFrequency_ClassFrequencyId", "dbo.ClassFrequency");
            DropForeignKey("dbo.StudentPresence", "Student_StudentId", "dbo.Student");
            DropForeignKey("dbo.StudentNote", "Student_StudentId", "dbo.Student");
            DropForeignKey("dbo.ClassDiary", "SchoolClass_SchoolClassId", "dbo.SchoolClass");
            DropForeignKey("dbo.Evaluetion", "ClassPlan_ClassPlanId", "dbo.ClassPlan");
            DropForeignKey("dbo.ClassGoals", "ClassPlan_ClassPlanId", "dbo.ClassPlan");
            DropForeignKey("dbo.Chores", "ClassPlan_ClassPlanId", "dbo.ClassPlan");
            DropIndex("dbo.SchoolEvent", new[] { "SchoolCalendar_SchoolCalendarId" });
            DropIndex("dbo.SchoolEvent", new[] { "AbstractSchoolEventId" });
            DropIndex("dbo.ClassSchedule", new[] { "ClassPlan_ClassPlanId" });
            DropIndex("dbo.ClassSchedule", new[] { "SchoolCalendar_SchoolCalendarId" });
            DropIndex("dbo.ClassSchedule", new[] { "AbstractSchoolEventId" });
            DropIndex("dbo.LessonsContent", new[] { "ClassPlan_ClassPlanId" });
            DropIndex("dbo.SchoolCalendar", new[] { "TeacherID" });
            DropIndex("dbo.School", new[] { "Teacher_TeacherId" });
            DropIndex("dbo.Student", new[] { "SchoolClass_SchoolClassId" });
            DropIndex("dbo.StudentPresence", new[] { "ClassFrequency_ClassFrequencyId" });
            DropIndex("dbo.StudentPresence", new[] { "Student_StudentId" });
            DropIndex("dbo.ClassFrequency", new[] { "SchoolClass_SchoolClassId" });
            DropIndex("dbo.SchoolClass", new[] { "Teacher_TeacherId" });
            DropIndex("dbo.SchoolClass", new[] { "School_SchoolId" });
            DropIndex("dbo.ClassDiary", new[] { "SchoolClass_SchoolClassId" });
            DropIndex("dbo.StudentNote", new[] { "Evaluetion_EvaluetionId" });
            DropIndex("dbo.StudentNote", new[] { "ClassDiary_ClassDiaryId" });
            DropIndex("dbo.StudentNote", new[] { "Student_StudentId" });
            DropIndex("dbo.Evaluetion", new[] { "ClassPlan_ClassPlanId" });
            DropIndex("dbo.ClassGoals", new[] { "ClassPlan_ClassPlanId" });
            DropIndex("dbo.Chores", new[] { "ClassPlan_ClassPlanId" });
            DropIndex("dbo.ClassPlan", new[] { "Teacher_TeacherId" });
            DropTable("dbo.SchoolEvent");
            DropTable("dbo.ClassSchedule");
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.LessonsContent");
            DropTable("dbo.SchoolCalendar");
            DropTable("dbo.Teacher");
            DropTable("dbo.School");
            DropTable("dbo.Student");
            DropTable("dbo.StudentPresence");
            DropTable("dbo.ClassFrequency");
            DropTable("dbo.SchoolClass");
            DropTable("dbo.ClassDiary");
            DropTable("dbo.StudentNote");
            DropTable("dbo.Evaluetion");
            DropTable("dbo.ClassGoals");
            DropTable("dbo.Chores");
            DropTable("dbo.ClassPlan");
            DropTable("dbo.AbstractSchoolEvent");
        }
    }
}
