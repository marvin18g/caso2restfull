using Aplicacion.Interfaces;
using Aplicacion.Wrappers;
using AutoMapper;
using Dominio.Entidades;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Feautres.Libros.Comandos.ModificarLibro
{
    public  class ModificarProducto : IRequest<Respuesta<int>>
    {
        public int id { get; set; }
        public string producto { get; set; }
      

        public DateTime fechaRegistro { get; set; }

        public double precioCompra { get; set; }

        public double PrecioVenta { get; set; }

        public string Existencias { get; set; }

        public int? categoriaId { get; set; }

    }
    public class ModificarLibroHandler : IRequestHandler<ModificarProducto, Respuesta<int>>
    {
        private readonly IRepositorioAsincrono<Producto> _repositorioAsincrono;
        private readonly IMapper _mapper;

        public ModificarLibroHandler(IRepositorioAsincrono<Producto> repositorioAsincrono, IMapper mapper)
        {
            _repositorioAsincrono = repositorioAsincrono;
            _mapper = mapper;
        }

        public async Task<Respuesta<int>> Handle(ModificarProducto request, CancellationToken cancellationToken)
        {
            var libro = await _repositorioAsincrono.GetByIdAsync(request.id);


            if (libro == null)
            {
                throw new KeyNotFoundException($" Registro no encontrado con el id {request.id}");

            }
            else
            {

                libro.producto = request.producto;
                
                libro.fechaRegistro = request.fechaRegistro;
                libro.precioCompra = request.precioCompra;

                libro.precioCompra = request.PrecioVenta;

                libro.Existencias = request.Existencias;

              
              

                await _repositorioAsincrono.UpdateAsync(libro);

                return new Respuesta<int>(libro.Id);

            }
        }
    }
}

