namespace Pendu_Projet_Final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HistoriqueEnregistrements",
                c => new
                    {
                        HistoriqueId = c.Int(nullable: false, identity: true),
                        Mot = c.String(),
                        Pointage = c.Int(nullable: false),
                        Erreurs = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Temps = c.String(),
                        Resultat = c.String(),
                    })
                .PrimaryKey(t => t.HistoriqueId);
            
            CreateTable(
                "dbo.Mots",
                c => new
                    {
                        MotId = c.Int(nullable: false, identity: true),
                        MotDictionnaire = c.String(),
                        Langue = c.String(),
                        Niveau = c.String(),
                    })
                .PrimaryKey(t => t.MotId);
            
            CreateTable(
                "dbo.PreferencesEnregistrements",
                c => new
                    {
                        PreferencesId = c.Int(nullable: false, identity: true),
                        Langue = c.String(),
                        Niveau = c.String(),
                    })
                .PrimaryKey(t => t.PreferencesId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PreferencesEnregistrements");
            DropTable("dbo.Mots");
            DropTable("dbo.HistoriqueEnregistrements");
        }
    }
}
