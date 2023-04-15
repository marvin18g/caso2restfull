
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

namespace Aplicacion.Feautres.Libros.Comandos.CrearLibro
{

        public class CrearProducto : IRequest<Respuesta<int>>
        {
        public string producto { get; set; }

        public DateTime fechaRegistro { get; set; }

        public double precioCompra { get; set; }

        public double PrecioVenta { get; set; }

        public string Existencias { get; set; }

        public int categoriaId { get; set; }


    }

        public class CrearClienteHandler : IRequestHandler<CrearProducto, Respuesta<int>>
        
        {
        private readonly IRepositorioAsincrono<Producto> _repositorioAsincrono; //agregar constructor
        private readonly IMapper _mapper; //agregar parametros
        public CrearClienteHandler(IRepositorioAsincrono<Producto> repositorioAsincrono, IMapper mapper)
        {
            _repositorioAsincrono = repositorioAsincrono;
            _mapper = mapper;
        }
    
        public async Task<Respuesta<int>> Handle(CrearProducto request, CancellationToken cancellationToken)
            {
            var nuevoRegistro = _mapper.Map<Producto>(request);
            var data = await _repositorioAsincrono.AddAsync(nuevoRegistro);
            return new Respuesta<int>(data.Id);
            }
        }
    }

