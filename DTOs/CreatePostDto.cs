using System.ComponentModel.DataAnnotations;

namespace BlogApi.DTOs
{
    public class CreatePostDto
    {
        [Required]
        [StringLength(200)]
        public string Titulo { get; set; }

        [Required]
        public string Conteudo { get; set; }
    }
}