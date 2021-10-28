namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambioProp : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Productos", name: "IdCategoria", newName: "Id_Categoria");
            RenameColumn(table: "dbo.Productos", name: "IdProveedor", newName: "Id_Proveedor");
            RenameColumn(table: "dbo.Productos", name: "IdSubcategoria", newName: "Id_Subcategoria");
            RenameIndex(table: "dbo.Productos", name: "IX_IdCategoria", newName: "IX_Id_Categoria");
            RenameIndex(table: "dbo.Productos", name: "IX_IdSubcategoria", newName: "IX_Id_Subcategoria");
            RenameIndex(table: "dbo.Productos", name: "IX_IdProveedor", newName: "IX_Id_Proveedor");
            DropColumn("dbo.SubCategorias", "Id_Categoria");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SubCategorias", "Id_Categoria", c => c.Int(nullable: false));
            RenameIndex(table: "dbo.Productos", name: "IX_Id_Proveedor", newName: "IX_IdProveedor");
            RenameIndex(table: "dbo.Productos", name: "IX_Id_Subcategoria", newName: "IX_IdSubcategoria");
            RenameIndex(table: "dbo.Productos", name: "IX_Id_Categoria", newName: "IX_IdCategoria");
            RenameColumn(table: "dbo.Productos", name: "Id_Subcategoria", newName: "IdSubcategoria");
            RenameColumn(table: "dbo.Productos", name: "Id_Proveedor", newName: "IdProveedor");
            RenameColumn(table: "dbo.Productos", name: "Id_Categoria", newName: "IdCategoria");
        }
    }
}
