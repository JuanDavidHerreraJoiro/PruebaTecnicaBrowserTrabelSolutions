using Datos;
using Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static TheLibrary.Model.EditorialModel;
using System.Collections.Generic;
using System.Linq;
using static TheLibrary.Model.LibroModel;
using Entidad;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace TheLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private readonly LibroServices _libroServices;
        private readonly AutorServices _autorServices;
        public LibroController(LibraryContext context)
        {
            _libroServices = new LibroServices(context);
            _autorServices = new AutorServices(context);

        }

        // GET: api/<LibroController>
        [HttpGet]
        public IEnumerable<LibroViewModel> Get()
        {
            return _libroServices.ConsultarTodos()!.Select(c => new LibroViewModel(c));
        }


        // GET api/<LibroController>/5
        [HttpGet("{id}")]
        public ActionResult<LibroViewModel> Get(int id)
        {
            var libro = _libroServices.BuscarLibro(id);

            if (libro == null)
            {
                return NotFound("No se encontro el Libro");
            }

            return Ok(new LibroViewModel(libro!));
        }

        // DELETE api/<LibroController>/5
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            string mensaje = _libroServices.Eliminar(id);

            return Ok(mensaje);
        }

        // POST api/<LibroController>
        [HttpPost]
        public ActionResult<LibroViewModel> Post(LibroInputModel libroInput)
        {
            var libro = Mapear(libroInput);
            
            foreach (var item in libroInput.Id_Autores)
            {
                libro.Autores.Add(_autorServices.BuscarAutor(item));
            }

            var respuesta = _libroServices.GuardarLibro(libro);

            if (respuesta.Error)
            {
                ModelState.AddModelError("Guardar libro", respuesta.Mensaje!);
                var problemDetails = new ValidationProblemDetails(ModelState)
                {
                    Status = StatusCodes.Status500InternalServerError,
                };

                return StatusCode(500, problemDetails);
            }
            return Ok(new LibroViewModel(respuesta.Objeto!));
        }

        // PUT api/<LibroController>/5
        [HttpPut("{id}")]
        public ActionResult<string> Put(int id, LibroUpdateModel libroUpdate)
        {
            var librobuscar = _libroServices.BuscarLibro(id);

            if (librobuscar == null)
            {
                return BadRequest("Libro no encontrado");
            }

            Libro libro = MapearLibroUpdate(libroUpdate, librobuscar.ISBN!);

            var mensaje = _libroServices.Modificar(libro);

            return Ok(mensaje);
        }

        [NonAction]
        public Libro Mapear(LibroInputModel libroInputModel)
        {
            Libro libro = new Libro
            {
                Editoriales_id = libroInputModel.Editoriales_id,
                Titulo = libroInputModel.Titulo,
                Sinopsis = libroInputModel.Sinopsis,
                N_paginas = libroInputModel.N_paginas
            };
            return libro;
        }

        [NonAction]
        public Libro MapearLibroUpdate(LibroUpdateModel libroUpdate, int isbn)
        {
            Libro libro = new Libro
            {
                ISBN = isbn,
                Editoriales_id = libroUpdate.Editoriales_id,
                Titulo = libroUpdate.Titulo,
                Sinopsis = libroUpdate.Sinopsis,
                N_paginas = libroUpdate.N_paginas
            };
            return libro;
        }
    }
}
