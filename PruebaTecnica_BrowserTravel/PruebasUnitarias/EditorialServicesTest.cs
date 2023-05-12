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
    public class EditorialServicesTest
    {
        private LibraryContext _context;
        private EditorialServices _editorialServices;

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

            // Inicializar la instancia de EditorialServices
            _editorialServices = new EditorialServices(_context);
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
            var editoriales = new List<Editorial>
            {

            };

            _context.Editoriales.AddRange(editoriales);
            _context.SaveChanges();

            // Ejecutar
            var result = _editorialServices.ConsultarTodos();

            // Verificar
            //Assert.IsNull(result);
            Assert.AreEqual(0, result.Count());
        }

        [Test]
        public void TestConsultarTodos()
        {
            // Preparar
            var editoriales = new List<Editorial>
            {
                new Editorial { Id = 1, Nombre = "Editorial 1", Sede = "Sede 1"},
                new Editorial { Id = 2, Nombre = "Editorial 2", Sede = "Sede 2" },
                new Editorial { Id = 3, Nombre = "Editorial 3", Sede = "Sede 3" }
            };

            _context.Editoriales.AddRange(editoriales);
            _context.SaveChanges();

            // Ejecutar
            var result = _editorialServices.ConsultarTodos();

            // Verificar
            CollectionAssert.AreEqual(editoriales.Select(a => a.Id), result.Select(a => a.Id));
        }

        [Test]
        public void TestBuscarEditorial()
        {
            // Preparar
            var editoriales = new List<Editorial>
            {
                new Editorial { Id = 1, Nombre = "Editorial 1", Sede = "Sede 1"},
                new Editorial { Id = 2, Nombre = "Editorial 2", Sede = "Sede 2" },
                new Editorial { Id = 3, Nombre = "Editorial 3", Sede = "Sede 3" }
            };

            _context.Editoriales.AddRange(editoriales);
            _context.SaveChanges();
            
            // Ejecutar
            var result = _editorialServices.BuscarEditorial(2);

            // Verificar
            Assert.AreEqual(editoriales.Where(a => a.Id == result.Id).First().Id, result.Id);
        }

        [Test]
        public void TestBuscarEditorialNull()
        {
            // Preparar
            var editoriales = new List<Editorial>
            {
                new Editorial { Id = 1, Nombre = "Editorial 1", Sede = "Sede 1"},
                new Editorial { Id = 2, Nombre = "Editorial 2", Sede = "Sede 2" },
                new Editorial { Id = 3, Nombre = "Editorial 3", Sede = "Sede 3" }
            };

            _context.Editoriales.AddRange(editoriales);
            _context.SaveChanges();

            // Ejecutar
            var result = _editorialServices.BuscarEditorial(4);
            // Verificar
            Assert.IsNull(result);
        }
    }
}
