namespace Capa.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class matricula : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "Matricula", c => c.String(nullable: false, maxLength: 70));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuarios", "Matricula");
        }
    }
}
