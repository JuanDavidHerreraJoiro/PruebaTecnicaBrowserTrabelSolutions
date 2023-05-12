using Datos;
using Entidad;
using Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TheLibrary.Model;
using static TheLibrary.Model.EditorialModel;

namespace TheLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EditorController : ControllerBase
    {
        private readonly EditorialServices _editorialServices;
        public EditorController(LibraryContext context)
        {
            _editorialServices = new EditorialServices(context);
        }

        // GET: api/<EditorController>
        [HttpGet]
        public IEnumerable<EditorialViewModel> Get() => _editorialServices.ConsultarTodos()!.Select(c => new EditorialViewModel(c));

        // GET api/<EditorController>/5
        [HttpGet("{id}")]
        public ActionResult<EditorialViewModel> Get(int id)
        {
            var editorial = _editorialServices.BuscarEditorial(id);

            if (editorial == null)
            {
                return NotFound("No se encontro la editorial");
            }

            return Ok(new EditorialViewModel(editorial!));
        }

        // POST api/<EditorialController>
        [HttpPost]
        public ActionResult<EditorialViewModel> Post(EditorialInputModel editorialInput)
        {
            var editorial = Mapear(editorialInput);

            var respuesta = _editorialServices.GuardarEditorial(editorial);

            if (respuesta.Error)
            {
                ModelState.AddModelError("Guardar editorial", respuesta.Mensaje!);
                var problemDetails = new ValidationProblemDetails(ModelState)
                {
                    Status = StatusCodes.Status500InternalServerError,
                };

                return StatusCode(500, problemDetails);
            }

            return Ok(new EditorialViewModel(respuesta.Objeto!));
        }

        // DELETE api/<EditorialController>/5
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            string mensaje = _editorialServices.Eliminar(id);

            return Ok(mensaje);
        }

        // PUT api/<EditorialController>/5
        [HttpPut("{id}")]
        public ActionResult<string> Put(int id, EditorialUpdateModel editorialUpdate)
        {
            var editorialbuscar = _editorialServices.BuscarEditorial(id);

            if (editorialbuscar == null)
            {
                return BadRequest("Editorial no encontrado");
            }

            Editorial editorial = MapearEditorialUpdate(editorialUpdate, editorialbuscar.Id!);

            var mensaje = _editorialServices.Modificar(editorial);

            return Ok(mensaje);
        }

        [NonAction]
        public Editorial Mapear(EditorialInputModel editorialInputModel)
        {
            Editorial editorial = new Editorial
            {
                Nombre = editorialInputModel.Nombre,
                Sede = editorialInputModel.Sede
            };

            return editorial;
        }

        [NonAction]
        public Editorial MapearEditorialUpdate(EditorialUpdateModel editorialUpdate, int id)
        {
            Editorial editorial = new Editorial
            {
                Id = id,
                Nombre = editorialUpdate.Nombre,
                Sede = editorialUpdate.Sede
            };

            return editorial;
        }
    }
}
