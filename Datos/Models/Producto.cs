using Productos.Models.Datos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos.Models
{
    [Table("Productos")]
    public class Producto
    {
        [Key]
        public int Id { get; set; }


        [Required]//Not null
        [Column(TypeName = "varchar")]//tipo de dato de SQL Server
        [MaxLength(50)]//hasta 50 
        public string Nombre { get; set; }

        [Column(TypeName = "varchar")]//tipo de dato de SQL Server
        [MaxLength(50)]//hasta 50 
        public string Descripcion { get; set; }

        [Required]
        public decimal PrecioCosto { get; set; }
        [Required]
        public decimal Margen { get; set; }


        public int Id_Categoria { get; set; }

        [ForeignKey("Id_Categoria")]
        public Categoria Categoria { get; set; }

        public int Id_Subcategoria { get; set; }

        [ForeignKey("Id_Subcategoria")]
        public SubCategoria SubCategoria { get; set; }

        public int Id_Proveedor { get; set; }
        [ForeignKey("Id_Proveedor")]
        public Proveedor Proveedor { get; set; }

    }

}
