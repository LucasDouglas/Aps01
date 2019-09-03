namespace TrabalhoCsharp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Compromissos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(maxLength: 200),
                        Inicio = c.DateTime(nullable: false),
                        Termino = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contatos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Sobrenome = c.String(),
                        DataNascimento = c.DateTime(nullable: false),
                        Telefone = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ContatoCompromissoes",
                c => new
                    {
                        Contato_Id = c.Int(nullable: false),
                        Compromisso_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Contato_Id, t.Compromisso_Id })
                .ForeignKey("dbo.Contatos", t => t.Contato_Id, cascadeDelete: true)
                .ForeignKey("dbo.Compromissos", t => t.Compromisso_Id, cascadeDelete: true)
                .Index(t => t.Contato_Id)
                .Index(t => t.Compromisso_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ContatoCompromissoes", "Compromisso_Id", "dbo.Compromissos");
            DropForeignKey("dbo.ContatoCompromissoes", "Contato_Id", "dbo.Contatos");
            DropIndex("dbo.ContatoCompromissoes", new[] { "Compromisso_Id" });
            DropIndex("dbo.ContatoCompromissoes", new[] { "Contato_Id" });
            DropTable("dbo.ContatoCompromissoes");
            DropTable("dbo.Contatos");
            DropTable("dbo.Compromissos");
        }
    }
}
