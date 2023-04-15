using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.DTOs
{
    public class ProductoDto
    {
        public int Id { get; set; }
        public string producto { get; set; }
       

        public DateTime fechaRegistro { get; set; }

        public double precioCompra { get; set; }

        public double PrecioVenta { get; set; }

        public string Existencias { get; set; }

    }
}
