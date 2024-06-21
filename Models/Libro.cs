using System.ComponentModel.DataAnnotations;

namespace BibliotecaApp.Models
{
    public class Libro
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Titulo { get; set; }

        [Required]
        [StringLength(100)]
        public string Autor { get; set; }

        [Required]
        public int AñoPublicacion { get; set; }
    }
}

