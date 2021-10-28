namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambioProducto : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Proveedors", newName: "Proveedores");
            RenameTable(name: "dbo.Empresa", newName: "Empresas");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Empresas", newName: "Empresa");
            RenameTable(name: "dbo.Proveedores", newName: "Proveedors");
        }
    }
}
