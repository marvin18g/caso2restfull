using Aplicacion.DTOs;
using Aplicacion.Especificacion;
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

namespace Aplicacion.Feautres.Libros.Consultas.ObtenerTodosLibros
{
    public class ObtenerTodosProductos: IRequest<PaginadorRespuesta<List<ProductoDto>>>
    {
        public int NumeroPagina { get; set; }
        public int TamanioPagina { get; set; }
        public string producto { get; set; }

    }
    public class ObtenerTodosLibrosHandler : IRequestHandler<ObtenerTodosProductos, PaginadorRespuesta<List<ProductoDto>>>
    {
        private readonly IRepositorioAsincrono<Producto> _repositorioAsincrono;
        private readonly IMapper _mapper;

        public ObtenerTodosLibrosHandler(IRepositorioAsincrono<Producto> repositorioAsincrono, IMapper mapper)
        {
            _repositorioAsincrono = repositorioAsincrono;
            _mapper = mapper;

        }

        public async Task<PaginadorRespuesta<List<ProductoDto>>> Handle(ObtenerTodosProductos request, CancellationToken cancellationToken)
        {
            var libros = await _repositorioAsincrono.ListAsync(new PaginaProductoEspecificacion(request.TamanioPagina, request.NumeroPagina, request.producto));
            var librodto = _mapper.Map<List<ProductoDto>>(libros);

            return new PaginadorRespuesta<List<ProductoDto>>(librodto, request.NumeroPagina, request.TamanioPagina);
        }
    }
}
