namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambioPrp : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.SubCategorias", name: "IdCategoria", newName: "Id_Categoria");
            RenameIndex(table: "dbo.SubCategorias", name: "IX_IdCategoria", newName: "IX_Id_Categoria");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.SubCategorias", name: "IX_Id_Categoria", newName: "IX_IdCategoria");
            RenameColumn(table: "dbo.SubCategorias", name: "Id_Categoria", newName: "IdCategoria");
        }
    }
}
