namespace Capa.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MasTablas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Componentes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipoComponente = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Preguntas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        pregunta = c.String(nullable: false, maxLength: 1000),
                        ComponenteId = c.Int(nullable: false),
                        CapituloId = c.Int(nullable: false),
                       
                        
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Capitulos", t => t.CapituloId)
                .ForeignKey("dbo.Componentes", t => t.ComponenteId)
                .Index(t => t.CapituloId)
                .Index(t => t.ComponenteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Preguntas", "ComponenteId", "dbo.Componentes");
            DropForeignKey("dbo.Preguntas", "CapituloId", "dbo.Capitulos");
            DropIndex("dbo.Preguntas", new[] { "ComponenteId" });
            DropIndex("dbo.Preguntas", new[] { "CapituloId" });
            DropTable("dbo.Preguntas");
            DropTable("dbo.Componentes");
        }
    }
}
