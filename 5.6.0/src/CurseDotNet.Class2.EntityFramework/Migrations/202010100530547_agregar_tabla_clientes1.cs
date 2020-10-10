namespace CurseDotNet.Class2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregar_tabla_clientes1 : DbMigration
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
