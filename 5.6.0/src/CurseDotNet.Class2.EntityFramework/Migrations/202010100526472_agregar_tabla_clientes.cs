namespace CurseDotNet.Class2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregar_tabla_clientes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PrimerNombre = c.String(),
                        Apellido = c.String(),
                        Edad = c.Int(nullable: false),
                        Identidad = c.String(),
                        Direccion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
