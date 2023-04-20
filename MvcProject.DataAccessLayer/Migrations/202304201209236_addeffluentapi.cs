namespace MvcProject.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addeffluentapi : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Abouts", "AboutDetailsFirst", c => c.String(maxLength: 1000));
            AlterColumn("dbo.Abouts", "AboutDetailsSecond", c => c.String(maxLength: 1000));
            AlterColumn("dbo.Abouts", "AboutImageFirst", c => c.String(maxLength: 100));
            AlterColumn("dbo.Abouts", "AboutImageSecond", c => c.String(maxLength: 100));
            AlterColumn("dbo.Categories", "CategoryName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Categories", "CategoryDescription", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categories", "CategoryDescription", c => c.String());
            AlterColumn("dbo.Categories", "CategoryName", c => c.String());
            AlterColumn("dbo.Abouts", "AboutImageSecond", c => c.String());
            AlterColumn("dbo.Abouts", "AboutImageFirst", c => c.String());
            AlterColumn("dbo.Abouts", "AboutDetailsSecond", c => c.String());
            AlterColumn("dbo.Abouts", "AboutDetailsFirst", c => c.String());
        }
    }
}
