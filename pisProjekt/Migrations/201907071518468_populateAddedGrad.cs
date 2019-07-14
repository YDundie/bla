namespace pisProjekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateAddedGrad : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.upis", "grad", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.upis", "grad");
        }
    }
}
