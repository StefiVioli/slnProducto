namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class clases : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Descripcion = c.String(maxLength: 50, unicode: false),
                        PrecioCosto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Margen = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IdSubcategoria = c.Int(nullable: false),
                        IdProveedor = c.Int(nullable: false),
                        Categoria_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Proveedors", t => t.IdProveedor, cascadeDelete: true)
                .ForeignKey("dbo.SubCategorias", t => t.IdSubcategoria, cascadeDelete: true)
                .ForeignKey("dbo.Categorias", t => t.Categoria_Id)
                .Index(t => t.IdSubcategoria)
                .Index(t => t.IdProveedor)
                .Index(t => t.Categoria_Id);
            
            CreateTable(
                "dbo.Proveedors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        id_Empresa = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Empresa", t => t.id_Empresa, cascadeDelete: true)
                .Index(t => t.id_Empresa);
            
            CreateTable(
                "dbo.Empresa",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        CUIT = c.String(nullable: false, maxLength: 50, unicode: false),
                        id_DatosContacto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DatosContacto", t => t.id_DatosContacto, cascadeDelete: true)
                .Index(t => t.id_DatosContacto);
            
            CreateTable(
                "dbo.DatosContacto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                        Telefono = c.String(nullable: false, maxLength: 20, unicode: false),
                        Direccion = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SubCategorias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Id_Categoria = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        IdCategoria = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categorias", t => t.IdCategoria, cascadeDelete: false)
                .Index(t => t.IdCategoria);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Productos", "Categoria_Id", "dbo.Categorias");
            DropForeignKey("dbo.Productos", "IdSubcategoria", "dbo.SubCategorias");
            DropForeignKey("dbo.SubCategorias", "IdCategoria", "dbo.Categorias");
            DropForeignKey("dbo.Productos", "IdProveedor", "dbo.Proveedors");
            DropForeignKey("dbo.Proveedors", "id_Empresa", "dbo.Empresa");
            DropForeignKey("dbo.Empresa", "id_DatosContacto", "dbo.DatosContacto");
            DropIndex("dbo.SubCategorias", new[] { "IdCategoria" });
            DropIndex("dbo.Empresa", new[] { "id_DatosContacto" });
            DropIndex("dbo.Proveedors", new[] { "id_Empresa" });
            DropIndex("dbo.Productos", new[] { "Categoria_Id" });
            DropIndex("dbo.Productos", new[] { "IdProveedor" });
            DropIndex("dbo.Productos", new[] { "IdSubcategoria" });
            DropTable("dbo.SubCategorias");
            DropTable("dbo.DatosContacto");
            DropTable("dbo.Empresa");
            DropTable("dbo.Proveedors");
            DropTable("dbo.Productos");
            DropTable("dbo.Categorias");
        }
    }
}
