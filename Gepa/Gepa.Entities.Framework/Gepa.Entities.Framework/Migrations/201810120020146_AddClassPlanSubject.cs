namespace Gepa.Entities.Framework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClassPlanSubject : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClassPlan", "Subject", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClassPlan", "Subject");
        }
    }
}
