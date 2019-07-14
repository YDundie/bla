namespace pisProjekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedZemlja : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.upis", "zemlja", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.upis", "zemlja");
        }
    }
}
