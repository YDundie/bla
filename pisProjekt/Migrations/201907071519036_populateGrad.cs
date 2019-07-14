namespace pisProjekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateGrad : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM upis");
            Sql("INSERT INTO upis (ime,prezime,brojTelefona,adresa,brojAdrese,zemlja,grad) VALUES ('Marko','Mustac',0996929459,'Ivana Zbulja', 44,'Croatia','Čakovec')");
            Sql("INSERT INTO upis (ime,prezime,brojTelefona,adresa,brojAdrese,zemlja,grad) VALUES ('Ivan','Mustac',0995040090,'Ivana Zbulja', 46,'Croatia','Čakovec')");
            Sql("INSERT INTO upis (ime,prezime,brojTelefona,adresa,brojAdrese,zemlja,grad) VALUES ('Ljubica','Mustac',098626508,'Ivana Zbulja', 48,'Croatia','Čakovec')");
        }
        
        public override void Down()
        {
        }
    }
}
