using LivroCRUDNET.Models;
using Microsoft.EntityFrameworkCore;

namespace LivroCRUDNET.Repositories
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Genero> Generos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livro>()
                .Property(b => b.AnoPublicacao)
                .HasColumnName("ano_publicacao");

            modelBuilder.Entity<Livro>()
                .Property(b => b.GeneroId)
                .HasColumnName("genero_id");
        }
    }
}
