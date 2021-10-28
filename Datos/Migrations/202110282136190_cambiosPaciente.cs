namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambiosPaciente : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Productos", "Categoria_Id", "dbo.Categorias");
            DropIndex("dbo.Productos", new[] { "Categoria_Id" });
            RenameColumn(table: "dbo.Productos", name: "Categoria_Id", newName: "IdCategoria");
            AlterColumn("dbo.Productos", "IdCategoria", c => c.Int(nullable: false));
            CreateIndex("dbo.Productos", "IdCategoria");
            AddForeignKey("dbo.Productos", "IdCategoria", "dbo.Categorias", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Productos", "IdCategoria", "dbo.Categorias");
            DropIndex("dbo.Productos", new[] { "IdCategoria" });
            AlterColumn("dbo.Productos", "IdCategoria", c => c.Int());
            RenameColumn(table: "dbo.Productos", name: "IdCategoria", newName: "Categoria_Id");
            CreateIndex("dbo.Productos", "Categoria_Id");
            AddForeignKey("dbo.Productos", "Categoria_Id", "dbo.Categorias", "Id");
        }
    }
}
