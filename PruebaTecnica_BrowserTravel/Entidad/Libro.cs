using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidad
{
    public class Libro
    {
        [Key]
        public int ISBN { get; set; }

        [ForeignKey("Editorial")]
        public int Editoriales_id { get; set; }
        public Editorial Editorial { get; set; } 
        public string Titulo { get; set; }
        public string Sinopsis { get; set; }
        public string N_paginas { get; set; }
        public List<Autor> Autores { get; set; } = new List<Autor>();
    }
}
