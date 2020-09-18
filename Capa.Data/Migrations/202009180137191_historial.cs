namespace Capa.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class historial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HistorialPreguntas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UsuarioId = c.Int(nullable: false),
                        CapituloId = c.Int(nullable: false),
                        PreguntaId = c.Int(nullable: false)
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Capitulos", t => t.CapituloId)
                .ForeignKey("dbo.Preguntas", t => t.PreguntaId)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId)
                .Index(t => t.CapituloId)
                .Index(t => t.PreguntaId)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.HistorialRespuestas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RespuestaId = c.Int(nullable: false),
                        HistorialPreguntaId = c.Int(nullable: false),                        
                    
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HistorialPreguntas", t => t.HistorialPreguntaId)
                .ForeignKey("dbo.Respuestas", t => t.RespuestaId)
                .Index(t => t.HistorialPreguntaId)
                .Index(t => t.RespuestaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HistorialPreguntas", "UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.HistorialPreguntas", "PreguntaId", "dbo.Preguntas");
            DropForeignKey("dbo.HistorialRespuestas", "RespuestaId", "dbo.Respuestas");
            DropForeignKey("dbo.HistorialRespuestas", "HistorialPreguntaId", "dbo.HistorialPreguntas");
            DropForeignKey("dbo.HistorialPreguntas", "CapituloId", "dbo.Capitulos");
            DropIndex("dbo.HistorialRespuestas", new[] { "RespuestaId" });
            DropIndex("dbo.HistorialRespuestas", new[] { "HistorialPreguntaId" });
            DropIndex("dbo.HistorialPreguntas", new[] { "UsuarioId" });
            DropIndex("dbo.HistorialPreguntas", new[] { "PreguntaId" });
            DropIndex("dbo.HistorialPreguntas", new[] { "CapituloId" });
            DropTable("dbo.HistorialRespuestas");
            DropTable("dbo.HistorialPreguntas");
        }
    }
}
