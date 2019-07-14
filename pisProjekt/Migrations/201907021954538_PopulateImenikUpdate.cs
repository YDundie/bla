namespace pisProjekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateImenikUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.upis", "ime", c => c.String(maxLength: 255));
            AlterColumn("dbo.upis", "prezime", c => c.String(maxLength: 255));
            AlterColumn("dbo.upis", "adresa", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.upis", "adresa", c => c.String());
            AlterColumn("dbo.upis", "prezime", c => c.String());
            AlterColumn("dbo.upis", "ime", c => c.String());
        }
    }
}
