using Ardalis.Specification;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Especificacion
{
    public  class PaginaProductoEspecificacion : Specification<Producto>
    {
        public PaginaProductoEspecificacion(int tamanioPagina, int numeroPagina, string producto)
        {
            Query.Skip((numeroPagina - 1) * tamanioPagina).Take(tamanioPagina);


            if(!string.IsNullOrEmpty(producto))
            {
                Query.Search(x => x.producto, "%" + producto + "%");
            }
        }
    }
}
