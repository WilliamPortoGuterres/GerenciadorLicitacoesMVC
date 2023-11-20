namespace GerenciadorLicitacoesMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LicitacaoEntities",
                c => new
                    {
                        LicitacaoId = c.Int(nullable: false, identity: true),
                        Numero = c.String(nullable: false, maxLength: 100),
                        Descricao = c.String(nullable: false, maxLength: 500),
                        DataAbertura = c.DateTime(nullable: false),
                        Status = c.String(nullable: false, maxLength: 20),
                        UsuarioId = c.Int(),
                    })
                .PrimaryKey(t => t.LicitacaoId)
                .ForeignKey("dbo.UsuarioEntities", t => t.UsuarioId)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.UsuarioEntities",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.UsuarioId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LicitacaoEntities", "UsuarioId", "dbo.UsuarioEntities");
            DropIndex("dbo.LicitacaoEntities", new[] { "UsuarioId" });
            DropTable("dbo.UsuarioEntities");
            DropTable("dbo.LicitacaoEntities");
        }
    }
}
