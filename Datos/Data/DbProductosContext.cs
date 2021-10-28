using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Productos.Models;
using Productos.Models.Datos.Models;

namespace Datos.Data
{
    class DbProductosContext: DbContext
    {
        //constructor
        public DbProductosContext() : base("KeyDbProductos") { }

        //propiedades DbSet<m>
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<SubCategoria> SubCategorias { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<DatosContacto> DatosContactos { get; set; }
    }
}
