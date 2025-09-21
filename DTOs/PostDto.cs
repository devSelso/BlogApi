namespace BlogApi.DTOs
{
    // DTO para retornar informações de um Post
    public class PostDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public DateTime DataPublicacao { get; set; }
    }
}