namespace pisProjekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropAllData : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM upis");
        }
        
        public override void Down()
        {
        }
    }
}
