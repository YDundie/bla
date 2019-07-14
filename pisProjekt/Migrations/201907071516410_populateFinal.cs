namespace pisProjekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateFinal : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO upis (ime,prezime,brojTelefona,adresa,brojAdrese,zemlja) VALUES ('Marko','Mustac',0996929459,'Ivana Zbulja', 44,'Croatia')");
            Sql("INSERT INTO upis (ime,prezime,brojTelefona,adresa,brojAdrese,zemlja) VALUES ('Ivan','Mustac',0995040090,'Ivana Zbulja', 46,'Croatia')");
            Sql("INSERT INTO upis (ime,prezime,brojTelefona,adresa,brojAdrese,zemlja) VALUES ('Ljubica','Mustac',098626508,'Ivana Zbulja', 48,'Croatia')");
        }
        
        public override void Down()
        {
        }
    }
}
