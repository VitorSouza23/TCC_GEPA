namespace Gepa.Entities.Framework
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTeacher : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Teacher", "TeacherAccount_AccountId", "dbo.TeacherAccount");
            DropForeignKey("dbo.AdminAccount", "AccountId", "dbo.Account");
            DropForeignKey("dbo.TeacherAccount", "AccountId", "dbo.Account");
            DropIndex("dbo.Teacher", new[] { "TeacherAccount_AccountId" });
            DropIndex("dbo.AdminAccount", new[] { "AccountId" });
            DropIndex("dbo.TeacherAccount", new[] { "AccountId" });
            AddColumn("dbo.Teacher", "UserId", c => c.String());
            DropColumn("dbo.Teacher", "TeacherAccount_AccountId");
            DropTable("dbo.Account");
            DropTable("dbo.AdminAccount");
            DropTable("dbo.TeacherAccount");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TeacherAccount",
                c => new
                    {
                        AccountId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.AccountId);
            
            CreateTable(
                "dbo.AdminAccount",
                c => new
                    {
                        AccountId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.AccountId);
            
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        AccountId = c.Long(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 50),
                        Passworld = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.AccountId);
            
            AddColumn("dbo.Teacher", "TeacherAccount_AccountId", c => c.Long(nullable: false));
            DropColumn("dbo.Teacher", "UserId");
            CreateIndex("dbo.TeacherAccount", "AccountId");
            CreateIndex("dbo.AdminAccount", "AccountId");
            CreateIndex("dbo.Teacher", "TeacherAccount_AccountId");
            AddForeignKey("dbo.TeacherAccount", "AccountId", "dbo.Account", "AccountId");
            AddForeignKey("dbo.AdminAccount", "AccountId", "dbo.Account", "AccountId");
            AddForeignKey("dbo.Teacher", "TeacherAccount_AccountId", "dbo.TeacherAccount", "AccountId");
        }
    }
}
