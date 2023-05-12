using Entidad;
using Microsoft.EntityFrameworkCore;
using System;

namespace Datos
{
    public class LibraryContext: DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
            
        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Editorial> Editoriales { get; set; }
        public DbSet<Libro> Libros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>()
            .HasMany(e => e.Libros)
            .WithMany(e => e.Autores);
        }
    }
}
