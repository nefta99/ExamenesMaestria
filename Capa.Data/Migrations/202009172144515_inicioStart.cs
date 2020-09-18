namespace Capa.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicioStart : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Capitulos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 80),
                        FechaCreacion = c.DateTime(),
                        CreadoPorUsuarioId = c.Int(),
                        MateriaId = c.Int(nullable: true)
                        
                       
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Materias", t => t.MateriaId)
                .ForeignKey("dbo.Usuarios", t => t.CreadoPorUsuarioId)
                .Index(t => t.MateriaId)
                .Index(t => t.CreadoPorUsuarioId);
            
            CreateTable(
                "dbo.Materias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 80),
                        FechaCreacion = c.DateTime(),
                        CreadoPorUsuarioId = c.Int()
                       
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.CreadoPorUsuarioId)
                .Index(t => t.CreadoPorUsuarioId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 60),
                        ApellidoPaterno = c.String(nullable: false, maxLength: 70),
                        ApellidoMaterno = c.String(maxLength: 60),
                        Contrasenia = c.String(nullable: false, maxLength: 70),
                        TipoUsuarioId = c.Int(nullable: true),
                        
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoUsuarios", t => t.TipoUsuarioId)
                .Index(t => t.TipoUsuarioId);
            
            CreateTable(
                "dbo.TipoUsuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipoUsuario = c.String(nullable: false, maxLength: 60),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "TipoUsuarioId", "dbo.TipoUsuarios");
            DropForeignKey("dbo.Materias", "CreadoPorUsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.Capitulos", "CreadoPorUsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.Capitulos", "MateriaId", "dbo.Materias");
            DropIndex("dbo.Usuarios", new[] { "TipoUsuarioId" });
            DropIndex("dbo.Materias", new[] { "CreadoPorUsuarioId" });
            DropIndex("dbo.Capitulos", new[] { "CreadoPorUsuarioId" });
            DropIndex("dbo.Capitulos", new[] { "MateriaId" });
            DropTable("dbo.TipoUsuarios");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Materias");
            DropTable("dbo.Capitulos");
        }
    }
}
