using Datos;
using Entidad;
using Logica;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using TheLibrary.Controllers;
using TheLibrary.Model;

namespace PruebasUnitarias
{
    [TestFixture]

    public class AutorServicesTest
    {
        private LibraryContext _context;
        private AutorServices _autorServices;

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
            _autorServices = new AutorServices(_context);
        }

        [TearDown]
        public void TearDown()
        {
            // Eliminar la base de datos de prueba en memoria después de cada prueba
            _context.Database.EnsureDeleted();
        }

        [Test]
        public void TestConsultarTodos()
        {
            // Preparar
            var autores = new List<Autor>
            {
                new Autor { Id = 1, Nombre = "Autor 1", Apellido = "Autor 1"},
                new Autor { Id = 2, Nombre = "Autor 2", Apellido = "Autor 2" },
                new Autor { Id = 3, Nombre = "Autor 3", Apellido = "Autor 3" }
            };

            _context.Autores.AddRange(autores);
            _context.SaveChanges();

            // Ejecutar
            var result = _autorServices.ConsultarTodos();

            // Verificar
            CollectionAssert.AreEqual(autores.Select(a => a.Id), result.Select(a => a.Id));
        }
        [Test]
        public void TestConsultarTodosNull()
        {
            // Preparar
            var autores = new List<Autor>
            {
                
            };

            _context.Autores.AddRange(autores);
            _context.SaveChanges();

            // Ejecutar
            var result = _autorServices.ConsultarTodos();

            // Verificar
            //Assert.IsNull(result);
            Assert.AreEqual(0, result.Count());
        }

        [Test]
        public void TestBuscarAutor()
        {
            // Preparar
            var autores = new List<Autor>
            {
                new Autor { Id = 1, Nombre = "Autor 1", Apellido = "Autor 1"},
                new Autor { Id = 2, Nombre = "Autor 2", Apellido = "Autor 2" },
                new Autor { Id = 3, Nombre = "Autor 3", Apellido = "Autor 3" }
            };

            _context.Autores.AddRange(autores);
            _context.SaveChanges();

            // Ejecutar
            var result = _autorServices.BuscarAutor(2);

            // Verificar
            Assert.AreEqual(autores.Where(a=>a.Id == result.Id).First().Id, result.Id);
        }

        [Test]
        public void TestBuscarAutorNull()
        {
            // Preparar
            var autores = new List<Autor>
            {
                new Autor { Id = 1, Nombre = "Autor 1", Apellido = "Autor 1"},
                new Autor { Id = 2, Nombre = "Autor 2", Apellido = "Autor 2" },
                new Autor { Id = 3, Nombre = "Autor 3", Apellido = "Autor 3" }
            };

            _context.Autores.AddRange(autores);
            _context.SaveChanges();

            // Ejecutar
            var result = _autorServices.BuscarAutor(4);

            // Verificar
            Assert.IsNull(result);
        }
    }
}