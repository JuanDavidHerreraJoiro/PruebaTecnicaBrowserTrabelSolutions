using Entidad;
using System.ComponentModel.DataAnnotations;

namespace TheLibrary.Model
{
    public class EditorialModel
    {
        public class EditorialInputModel
        {
            [Required(ErrorMessage = "El nombre es requerido")]
            public string Nombre { get; set; }
            [Required(ErrorMessage = "La sede es requerido")]
            public string Sede { get; set; }

        }
        public class EditorialViewModel : EditorialInputModel
        {
            public EditorialViewModel(Editorial editor)
            {
                this.Id = editor.Id;
                this.Nombre = editor.Nombre;
                this.Sede = editor.Sede;
            }
            public int Id { get; set; }
        }

        public class EditorialUpdateModel
        {
            public string Nombre { get; set; }
            public string Sede { get; set; }
        }
    }
}
