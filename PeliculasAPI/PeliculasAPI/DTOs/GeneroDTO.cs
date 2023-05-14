using System.ComponentModel.DataAnnotations;

namespace PeliculasAPI.DTOs
{
    // Se hereda Nombre desde GeneroCreacionDTO
    public class GeneroDTO : GeneroCreacionDTO
    {
        public int Id { get; set; }


    }
}
