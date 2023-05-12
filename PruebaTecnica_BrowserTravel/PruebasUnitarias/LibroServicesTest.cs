using Datos;
using Entidad;
using Logica;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasUnitarias
{
    public class LibroServicesTest
    {
        private LibraryContext _context;
        private LibroServices _libroServices;

        [SetUp]
        public void Setup()
        {
            // Configurar la base de datos de prueba en memoria
            var options = new DbContextOptionsBuilder<LibraryContext>()
                .UseInMemoryDatabase(databaseName: "LibraryDB")
                .Options;

            // Inicializar el contexto de la base de datos
            _context = new LibraryContext(options);
            _context.Database.EnsureCreated();

            // Inicializar la instancia de AutorServices
            _libroServices = new LibroServices(_context);
        }

        [TearDown]
        public void TearDown()
        {
            // Eliminar la base de datos de prueba en memoria después de cada prueba
            _context.Database.EnsureDeleted();
        }

        [Test]
        public void TestConsultarTodosNull()
        {
            // Preparar
            var libros = new List<Libro>
            {

            };

            _context.Libros.AddRange(libros);
            _context.SaveChanges();

            // Ejecutar
            var result = _libroServices.ConsultarTodos();

            // Verificar
            //Assert.IsNull(result);
            Assert.AreEqual(0, result.Count());
        }

        [Test]
        public void TestConsultarTodos()
        {
            // Preparar
            var libros = new List<Libro>
            {
                new Libro { ISBN = 1, Titulo = "Titulo 1", N_paginas = "100", Editoriales_id  = 1,Editorial = new Editorial { Id = 1, Nombre = "Editorial 1", Sede = "Sede 1"}, Sinopsis="Sinopsis 1" , Autores = new List<Autor>{ 
                    new Autor { Id = 1, Nombre = "Autor 1", Apellido = "Autor 1"},
                    new Autor { Id = 2, Nombre = "Autor 2", Apellido = "Autor 2" } }
                },
                new Libro { ISBN = 2, Titulo = "Titulo 2", N_paginas = "200", Editoriales_id  = 2,Editorial = new Editorial { Id = 2, Nombre = "Editorial 2", Sede = "Sede 2"}, Sinopsis="Sinopsis 2" , Autores = new List<Autor>{
                    new Autor { Id = 3, Nombre = "Autor 3", Apellido = "Autor 3"},
                    new Autor { Id = 4, Nombre = "Autor 4", Apellido = "Autor 4" } }
                },
                new Libro { ISBN = 3, Titulo = "Titulo 3", N_paginas = "300", Editoriales_id  = 3,Editorial = new Editorial { Id = 3, Nombre = "Editorial 3", Sede = "Sede 3"}, Sinopsis="Sinopsis 3", Autores = new List<Autor>()}
            };

            _context.Libros.AddRange(libros);
            _context.SaveChanges();

            // Ejecutar
            var result = _libroServices.ConsultarTodos();

            // Verificar
            //Assert.AreEqual(result.Count(), libros.Count());
            CollectionAssert.AreEqual(libros.Select(a => a.ISBN), result.Select(a => a.ISBN));
        }
        
        [Test]
        public void TestBuscarLibro()
        {
            // Preparar
            var libros = new List<Libro>
            {
                 new Libro { ISBN = 3, Titulo = "Titulo 3", N_paginas = "300", Editoriales_id  = 1,Editorial = new Editorial { Id = 1, Nombre = "Editorial 1", Sede = "Sede 1"}, Sinopsis="Sinopsis 3"}
            };

            _context.Libros.AddRange(libros);
            _context.SaveChanges();

            // Ejecutar
            var result = _libroServices.BuscarLibro(3);

            // Verificar
            Assert.AreEqual(libros.Where(a => a.ISBN == result.ISBN).First().ISBN, result.ISBN);
        }

        [Test]
        public void TestBuscarLibroNull()
        {
            // Preparar
            var libros = new List<Libro>
            {
                new Libro { ISBN = 1, Titulo = "Titulo 1", N_paginas = "100", Editoriales_id  = 1, Sinopsis="Sinopsis 1", Autores = new List<Autor>()
                },
                new Libro { ISBN = 2, Titulo = "Titulo 2", N_paginas = "200", Editoriales_id  = 2, Sinopsis="Sinopsis 2" , Autores = new List<Autor>{
                    new Autor { Id = 3, Nombre = "Autor 3", Apellido = "Autor 3"},
                    new Autor { Id = 4, Nombre = "Autor 4", Apellido = "Autor 4" } }
                },
                new Libro { ISBN = 3, Titulo = "Titulo 3", N_paginas = "300", Editoriales_id  = 3, Sinopsis="Sinopsis 3", Autores = new List<Autor>()}
            };

            _context.Libros.AddRange(libros);
            _context.SaveChanges();

            // Ejecutar
            var result = _libroServices.BuscarLibro(4);
            // Verificar
            Assert.IsNull(result);
        }
    }
}
