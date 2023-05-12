using Datos;
using Entidad;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class AutorServices
    {
        private readonly LibraryContext _context;
        public AutorServices(LibraryContext context)
        {
            _context = context;
        }

        /*public async Task<IEnumerable<Autor>>? AutorByLibros(int libroId)
        {
            var autores = await _context?.Autores?
            .Include(a => a.AutoresLibros)
            .ThenInclude(al => al.autorLibro)
            .Where(a => a.AutoresLibros.Any(al => al.Libros_ISBN == libroId))
            .ToListAsync();

            return autores;
        }*/
        public IEnumerable<Autor> ConsultarTodos() => _context?.Autores?.Include(a => a.Libros).ToList();
        public Autor BuscarAutor(int id) => _context?.Autores?.Where(f => f.Id == id).Include(l => l.Libros).FirstOrDefault();

        public string Eliminar(int id)
        {
            try
            {
                var autor = _context?.Autores?.Find(id);

                if (autor != null)
                {
                    _context!.Autores!.Remove(autor);
                    _context.SaveChanges();

                    return ($"El autor {autor.Nombre} ha sido eliminado");
                }
                else
                {
                    return "El autor no se encuentra registrado";
                }
            }
            catch (SystemException)
            {
                return "Error al eliminar el autor";
            }
        }
        public string Modificar(Autor autorNuevo)
        {
            try
            {
                var autorViejo = _context?.Autores?.Find(autorNuevo.Id);

                if (autorViejo != null)
                {
                    autorViejo.Id = autorNuevo.Id;
                    autorViejo.Apellido = autorNuevo.Apellido;
                    autorViejo.Nombre = autorNuevo.Nombre;

                    _context!.Autores!.Update(autorViejo);
                    _context.SaveChanges();

                    return ($"El registro {autorNuevo.Id} ha sido modificado");
                }
                else
                {
                    return ($"El registro {autorNuevo.Id} no se encuentra registrado");
                }
            }
            catch (SystemException)
            {
                return "Error al modificar autor";
            }
        }
        public GuardarResponse<Autor> GuardarAutor(Autor autor)
        {
            try
            {
                _context!.Autores!.Add(autor);
                _context.SaveChanges();

                return new GuardarResponse<Autor>(autor);
            }
            catch (SystemException)
            {
                return new GuardarResponse<Autor>("Error al guardar el autor");
            }
        }

    }
}
