using System.ComponentModel.DataAnnotations;

namespace BlogApi.Models
{
    public class Comentario
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Autor { get; set; }

        [Required]
        public string Conteudo { get; set; }

        public DateTime DataPublicacao { get; set; } = DateTime.UtcNow;

        // Chave estrangeira para o Post
        public int PostId { get; set; }

        // Propriedade de navegação para o Post ao qual este comentário pertence
        public Post Post { get; set; }
    }
}