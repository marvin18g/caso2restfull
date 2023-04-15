using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Feautres.Libros.Comandos.EliminarLibro
{
    public class EliminarProductoValidacion : AbstractValidator<EliminarProducto>
    {
        public EliminarProductoValidacion()
        {
            RuleFor(p => p.id);
        }
    }
}
