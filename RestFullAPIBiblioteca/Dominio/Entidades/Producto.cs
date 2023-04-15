using Dominio.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Producto : Auditoria
    {
        public string producto { get; set; }
       
        public DateTime fechaRegistro { get; set; }

        public double precioCompra { get; set; }

        public double PrecioVenta { get; set; }

        public string Existencias { get; set; }

        public int categoriaId { get; set; }

        public Categorias? categoria { get; set; }

    }
}
