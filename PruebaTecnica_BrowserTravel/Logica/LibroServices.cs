using Datos;
using Entidad;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LibroServices
    {
        private readonly LibraryContext _context;
        public LibroServices(LibraryContext context)
        {
            _context = context;
        }
        /*
        public async Task<IEnumerable<Libro>> GetLibrosByAutorId(int autorId)
        {
            var libros = await _context?.Libros?
                .Include(e => e.Auto)
                .ThenInclude(al => al.Autor)
                .Where(l => l.AutoresLibros.Any(al => al.Autores_id == autorId))
                .ToListAsync();

            return libros;
        }*/

        public IEnumerable<Libro> ConsultarTodos()
        {
            var prueba = _context?.Libros.Include(e => e.Editorial).Include(a=>a.Autores).ToList();
            return prueba;
        } 
        public Libro BuscarLibro(int id) => _context?.Libros?.Where(f => f.ISBN == id).Include(l => l.Autores).Include(l => l.Editorial).FirstOrDefault();
        public string Eliminar(int id)
        {
            try
            {
                var libro = _context?.Libros?.Find(id);

                if (libro != null)
                {
                    _context!.Libros!.Remove(libro);
                    _context.SaveChanges();

                    return ($"El libro {libro.Titulo} ha sido eliminado");
                }
                else
                {
                    return "El libro no se encuentra registrado";
                }
            }
            catch (SystemException)
            {
                return "Error al eliminar el libro";
            }
        }
        public string Modificar(Libro libroNuevo)
        {
            try
            {
                var libroViejo = _context?.Libros?.Find(libroNuevo.ISBN);

                if (libroViejo != null)
                {
                    var editorial = _context?.Editoriales?.Find(libroNuevo.Editoriales_id);

                    if (editorial != null)
                    {
                        libroViejo.ISBN = libroNuevo.ISBN;
                        libroViejo.Editoriales_id = libroNuevo.Editoriales_id;
                        libroViejo.Titulo = libroNuevo.Titulo;
                        libroViejo.Sinopsis = libroNuevo.Sinopsis;
                        libroViejo.N_paginas = libroNuevo.N_paginas;

                        _context!.Libros!.Update(libroViejo);
                        _context.SaveChanges();

                        return ($"El registro {libroNuevo.ISBN} ha sido modificado");
                    }

                    return ($"Error al modificar el Editoriales_id {libroNuevo.Editoriales_id} no existe");
                }
                else
                {
                    return ($"El registro {libroNuevo.ISBN} no se encuentra registrado");
                }
            }
            catch (SystemException)
            {
                return "Error al modificar libro";
            }
        }
        public GuardarResponse<Libro> GuardarLibro(Libro libro)
        {
            try
            {
                var editorial = _context?.Editoriales?.Find(libro.Editoriales_id);

                if (editorial != null)
                {
                    _context!.Libros!.Add(libro);
                    _context.SaveChanges();
                    return new GuardarResponse<Libro>(libro);
                    
                }

                return new GuardarResponse<Libro>("Error al guardar el Editoriales_id no existe");

            }
            catch (SystemException)
            {
                return new GuardarResponse<Libro>("Error al guardar el libro");
            }
        }
    }
}
