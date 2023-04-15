﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Feautres.Libros.Comandos.CrearLibro
{
   public  class CrearProductoValidacion : AbstractValidator<CrearProducto>
    {
        public CrearProductoValidacion()
        {
            RuleFor(p => p.producto)
                .NotEmpty().WithMessage("{PropertyName} no puede ir vacio")
                .MaximumLength(200).WithMessage("{PropertyName} no debe de exceder de {MaxLength} caracteres");
             

            RuleFor(p => p.fechaRegistro)
               .NotEmpty().WithMessage("{PropertyName} no puede ir vacio");

            RuleFor(p => p.precioCompra)
             .NotEmpty().WithMessage("{PropertyName} no puede ir vacio");
            RuleFor(p => p.PrecioVenta)

             .NotEmpty().WithMessage("{PropertyName} no puede ir vacio");

            RuleFor(p => p.Existencias)

        .NotEmpty().WithMessage("{PropertyName} no puede ir vacio");

            





        }
    }
}
