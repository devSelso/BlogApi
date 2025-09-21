using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogApi.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Titulo { get; set; }

        [Required]
        public string Conteudo { get; set; }

        public DateTime DataPublicacao { get; set; } = DateTime.UtcNow;

        // Propriedade de navegação: um Post pode ter muitos Comentarios
        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();
    }
}