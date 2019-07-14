namespace pisProjekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newModelDefinition : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.upis", "ime", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.upis", "prezime", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.upis", "adresa", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.upis", "zemlja", c => c.String(nullable: false));
            AlterColumn("dbo.upis", "grad", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.upis", "grad", c => c.String());
            AlterColumn("dbo.upis", "zemlja", c => c.String());
            AlterColumn("dbo.upis", "adresa", c => c.String(maxLength: 255));
            AlterColumn("dbo.upis", "prezime", c => c.String(maxLength: 255));
            AlterColumn("dbo.upis", "ime", c => c.String(maxLength: 255));
        }
    }
}
