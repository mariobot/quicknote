namespace quicknote.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateCreation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Notes", "DateCreation", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Notes", "DateCreation");
        }
    }
}
