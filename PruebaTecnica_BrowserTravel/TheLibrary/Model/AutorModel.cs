using Entidad;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace TheLibrary.Model
{
    public class AutorInputModel
    {
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El apellido es requerido")]
        public string Apellido { get; set; }
        //public List<int> Id_Libros { get; set; }

    }
    public class AutorViewModel : AutorInputModel
    {
        public AutorViewModel(Autor autor)
        {
            this.Id= autor.Id;
            this.Nombre = autor.Nombre;
            this.Apellido = autor.Apellido;
            this.Libros = autor.Libros.Select(a => new Libro { ISBN = a.ISBN, Editoriales_id=a.Editoriales_id, Titulo = a.Titulo,Sinopsis = a.Sinopsis, N_paginas = a.N_paginas }).ToList();
            ;
        }
        public int Id { get; set; }
        public List<Libro> Libros { get; set; }

    }

    public class AutorUpdateModel
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<int> Id_Libros { get; set; }

    }
}
