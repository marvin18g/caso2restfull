using Aplicacion.Feautres.Libros.Comandos.CrearLibro;
using Aplicacion.Feautres.Libros.Comandos.EliminarLibro;
using Aplicacion.Feautres.Libros.Comandos.ModificarLibro;
using Aplicacion.Feautres.Libros.Consultas.ObtenerLibroPorId;
using Aplicacion.Feautres.Libros.Consultas.ObtenerTodosLibros;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiWeb.Controllers.v1
{
    [ApiVersion("1.0")]
    public class ProductoController : BaseApiController
    {
        //Post 
        [HttpPost]
       public async Task<IActionResult> Post(CrearProducto comando)
        {
            return Ok(await Mediator.Send(comando));
        }
        //GET
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {

            return Ok(await Mediator.Send(new ObtenerProductoId { Id = id }));
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, ModificarProducto comando)
        {
            if (id != comando.id)
                return BadRequest();
            return Ok(await Mediator.Send(comando));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
          
            return Ok(await Mediator.Send(new EliminarProducto { id = id}));
        }

        [HttpGet()]
        public async Task<IActionResult> Get([FromQuery] ObtenerTodoProductosParametros filter)
        {

            return Ok(await Mediator.Send(new ObtenerTodosProductos
            {
                NumeroPagina = filter.NumeroPagina,
                TamanioPagina = filter.TamanioPagina,
                producto = filter.producto
            }));
        }


    }
}
