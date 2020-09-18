namespace Capa.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Calificaciones : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Calificaciones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UsuarioId = c.Int(nullable: false),
                        Calificacion = c.Single(nullable: false),
                        CapituloId = c.Int(nullable: false),
                        
                       
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Capitulos", t => t.CapituloId)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId)
                .Index(t => t.CapituloId)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Respuestas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Respuesta = c.String(nullable: false, maxLength: 500),
                        Valor = c.Single(nullable: false),
                        PreguntaId = c.Int(nullable: false),
                        
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Preguntas", t => t.PreguntaId)
                .Index(t => t.PreguntaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Respuestas", "PreguntaId", "dbo.Preguntas");
            DropForeignKey("dbo.Calificaciones", "UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.Calificaciones", "CapituloId", "dbo.Capitulos");
            DropIndex("dbo.Respuestas", new[] { "PreguntaId" });
            DropIndex("dbo.Calificaciones", new[] { "UsuarioId" });
            DropIndex("dbo.Calificaciones", new[] { "CapituloId" });
            DropTable("dbo.Respuestas");
            DropTable("dbo.Calificaciones");
        }
    }
}
