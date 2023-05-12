using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class EditorialServices
    {
        private readonly LibraryContext _context;
        public EditorialServices(LibraryContext context)
        {
            _context = context;
        }

        public IEnumerable<Editorial> ConsultarTodos() => _context?.Editoriales?.ToList();
        public Editorial BuscarEditorial(int id) => _context?.Editoriales?.Find(id);

        public string Eliminar(int id)
        {
            try
            {
                var editorial = _context?.Editoriales?.Find(id);

                if (editorial != null)
                {
                    _context!.Editoriales!.Remove(editorial);
                    _context.SaveChanges();

                    return ($"La editorial {editorial.Nombre} ha sido eliminado");
                }
                else
                {
                    return "La editorial no se encuentra registrado";
                }
            }
            catch (SystemException)
            {
                return "Error al eliminar la editorial";
            }
        }
        public string Modificar(Editorial editorialNuevo)
        {
            try
            {
                var editorialViejo = _context?.Editoriales?.Find(editorialNuevo.Id);

                if (editorialViejo != null)
                {
                    editorialViejo.Id = editorialNuevo.Id;
                    editorialViejo.Nombre = editorialNuevo.Nombre;
                    editorialViejo.Sede = editorialNuevo.Sede;

                    _context!.Editoriales!.Update(editorialViejo);
                    _context.SaveChanges();

                    return ($"El registro {editorialNuevo.Id} ha sido modificado");
                }
                else
                {
                    return ($"El registro {editorialNuevo.Id} no se encuentra registrado");
                }
            }
            catch (SystemException)
            {
                return "Error al modificar la editorial";
            }
        }

        public GuardarResponse<Editorial> GuardarEditorial(Editorial editorial)
        {
            try
            {
                _context!.Editoriales!.Add(editorial);
                _context.SaveChanges();

                return new GuardarResponse<Editorial>(editorial);
            }
            catch (SystemException)
            {
                return new GuardarResponse<Editorial>("Error al guardar la editorial");
            }
        }
    }
}
