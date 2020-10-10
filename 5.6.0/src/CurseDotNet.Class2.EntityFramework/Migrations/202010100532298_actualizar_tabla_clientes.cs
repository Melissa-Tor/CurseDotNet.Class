namespace CurseDotNet.Class2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualizar_tabla_clientes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Telefono", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "Telefono");
        }
    }
}
