using Datos;
using Entidad;
using Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TheLibrary.Model;

namespace TheLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly AutorServices _autorServices;
        public AutorController(LibraryContext context)
        {
            _autorServices = new AutorServices(context);
        }

        // GET: api/<AutorController>
        [HttpGet]
        public IEnumerable<AutorViewModel> Get() => _autorServices.ConsultarTodos()!.Select(c => new AutorViewModel(c));

        // GET api/<AutorController>/5
        [HttpGet("{id}")]
        public ActionResult<AutorViewModel> Get(int id)
        {
            var autor = _autorServices.BuscarAutor(id);

            if (autor == null)
            {
                return NotFound("No se encontro el autor");
            }

            return Ok(new AutorViewModel(autor!));
        }

        // POST api/<AutorController>
        [HttpPost]
        public ActionResult<AutorViewModel> Post(AutorInputModel autorInput)
        {
            var autor = Mapear(autorInput);

            var respuesta = _autorServices.GuardarAutor(autor);

            if (respuesta.Error)
            {
                ModelState.AddModelError("Guardar autor", respuesta.Mensaje!);
                var problemDetails = new ValidationProblemDetails(ModelState)
                {
                    Status = StatusCodes.Status500InternalServerError,
                };

                return StatusCode(500, problemDetails);
            }

            return Ok(new AutorViewModel(respuesta.Objeto!));
        }

        // DELETE api/<AutorController>/5
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            string mensaje = _autorServices.Eliminar(id);

            return Ok(mensaje);
        }

        // PUT api/<AutorController>/5
        [HttpPut("{id}")]
        public ActionResult<string> Put(int id, AutorUpdateModel autorUpdate)
        {
            var autorbuscar = _autorServices.BuscarAutor(id);

            if (autorbuscar == null)
            {
                return BadRequest("Autor no encontrado");
            }

            Autor autor = MapearAutorUpdate(autorUpdate, autorbuscar.Id!);

            var mensaje = _autorServices.Modificar(autor);

            return Ok(mensaje);
        }

        [NonAction]
        public Autor Mapear(AutorInputModel autorInputModel)
        {
            Autor autor = new Autor
            {
                Nombre = autorInputModel.Nombre,
                Apellido = autorInputModel.Apellido
            };

            return autor;
        }

        [NonAction]
        public Autor MapearAutorUpdate(AutorUpdateModel autorUpdate, int id)
        {
            Autor autor = new Autor
            {
                Id = id,
                Nombre = autorUpdate.Nombre,
                Apellido = autorUpdate.Apellido
            };

            return autor;
        }
    }
}
