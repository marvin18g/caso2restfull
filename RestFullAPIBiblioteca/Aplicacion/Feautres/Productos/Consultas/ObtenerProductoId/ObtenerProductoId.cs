using Aplicacion.DTOs;
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

namespace Aplicacion.Feautres.Libros.Consultas.ObtenerLibroPorId
{
    public class ObtenerProductoId : IRequest<Respuesta<ProductoDto>>
    {

        public int Id { get; set; }

    }
    public class ObtenerlibroIdHandler : IRequestHandler<ObtenerProductoId, Respuesta<ProductoDto>>
    {
        private readonly IRepositorioAsincrono<Producto> _repositorioAsincrono;
        private readonly IMapper _mapper;

        public ObtenerlibroIdHandler(IRepositorioAsincrono<Producto> repositorioAsincrono, IMapper mapper)
        {
            
            _repositorioAsincrono = repositorioAsincrono;
            _mapper = mapper;
        }


        public async Task<Respuesta<ProductoDto>> Handle(ObtenerProductoId request, CancellationToken cancellationToken)
        {
            var libro = await _repositorioAsincrono.GetByIdAsync(request.Id);


            if (libro == null)
            {
                throw new KeyNotFoundException($" Registro no encontrado con el id {request.Id}");

            }
            else
            {

               var objetodto = _mapper.Map<ProductoDto>(libro);

                await _repositorioAsincrono.UpdateAsync(libro);

                return new Respuesta<ProductoDto>(objetodto);

            }
        }
    }
}
