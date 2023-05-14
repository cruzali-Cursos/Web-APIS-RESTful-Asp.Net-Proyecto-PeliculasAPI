using Microsoft.EntityFrameworkCore;
using PeliculasAPI.Entidades;

namespace PeliculasAPI
{
    public class ApplicationDbContextPeliculas : DbContext
    {
        public ApplicationDbContextPeliculas(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Genero> Generos { get; set; }
    }


}
