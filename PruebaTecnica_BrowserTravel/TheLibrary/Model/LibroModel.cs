using Entidad;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace TheLibrary.Model
{
    public class LibroModel
    {
        public class LibroInputModel
        {
            [Required(ErrorMessage = "El Editoriales_id es requerido")]
            public int Editoriales_id { get; set; }
            
            [Required(ErrorMessage = "El titulo es requerido")]
            public string Titulo { get; set; }
            [Required(ErrorMessage = "La sinopsis es requerido")]
            public string Sinopsis { get; set; }
            [Required(ErrorMessage = "El numero de paginas es requerido")]
            public string N_paginas { get; set; }

            public List<int> Id_Autores { get; set; }
        }
        public class LibroViewModel : LibroInputModel
        {
            public LibroViewModel(Libro libro)
            {
                this.ISBN = libro.ISBN;
                this.Editoriales_id = libro.Editoriales_id;
                this.Editorial = libro.Editorial;
                this.Titulo = libro.Titulo;
                this.Sinopsis = libro.Sinopsis;
                this.N_paginas = libro.N_paginas;
                this.Autores = libro.Autores.Select(a=> new Autor {Nombre = a.Nombre,Apellido = a.Apellido, Id = a.Id }).ToList();

            }
            public int ISBN { get; set; }
            public Editorial Editorial { get; set; }
            public List<Autor> Autores { get; set; }

        }

        public class LibroUpdateModel
        {
            public int Editoriales_id { get; set; }
            public string Titulo { get; set; }
            public string Sinopsis { get; set; }
            public string N_paginas { get; set; }
            public List<int> Id_Autores { get; set; }
        }
    }
}
