using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos.Models
{
    namespace Datos.Models
    {
        public class SubCategoria
        {
            public int Id { get; set; }
            
            [Required]
            [Column(TypeName = "varchar")]
            [MaxLength(50)]
            public string Nombre { get; set; }

            public List<Producto> Productos { get; set; }
            public int Id_Categoria { get; set; }
            [ForeignKey("Id_Categoria")]
            public Categoria categorias { get; set; }
        }
    }

}
