using BlogApi.Data;
using BlogApi.DTOs;
using BlogApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly BlogContext _context;

        public PostsController(BlogContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Obtém todos os posts.
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostDto>>> GetPosts()
        {
            var posts = await _context.Posts
                .Select(p => new PostDto // Mapeia para DTO
                {
                    Id = p.Id,
                    Titulo = p.Titulo,
                    Conteudo = p.Conteudo,
                    DataPublicacao = p.DataPublicacao
                })
                .ToListAsync();

            return Ok(posts);
        }

        /// <summary>
        /// Obtém um post específico pelo ID.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<PostDto>> GetPost(int id)
        {
            var post = await _context.Posts
                .Select(p => new PostDto
                {
                    Id = p.Id,
                    Titulo = p.Titulo,
                    Conteudo = p.Conteudo,
                    DataPublicacao = p.DataPublicacao
                })
                .FirstOrDefaultAsync(p => p.Id == id);

            if (post == null)
            {
                return NotFound(); // Retorna 404 se não encontrar
            }

            return Ok(post);
        }

        /// <summary>
        /// Cria um novo post.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<PostDto>> CreatePost(CreatePostDto createPostDto)
        {
            var post = new Post
            {
                Titulo = createPostDto.Titulo,
                Conteudo = createPostDto.Conteudo
            };

            _context.Posts.Add(post);
            await _context.SaveChangesAsync(); // Salva no banco de dados

            var postDto = new PostDto
            {
                Id = post.Id,
                Titulo = post.Titulo,
                Conteudo = post.Conteudo,
                DataPublicacao = post.DataPublicacao
            };

            // Retorna 201 Created com a localização do novo recurso e o objeto criado
            return CreatedAtAction(nameof(GetPost), new { id = post.Id }, postDto);
        }

        /// <summary>
        /// Atualiza um post existente.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePost(int id, CreatePostDto updatePostDto)
        {
            var post = await _context.Posts.FindAsync(id);

            if (post == null)
            {
                return NotFound();
            }

            post.Titulo = updatePostDto.Titulo;
            post.Conteudo = updatePostDto.Conteudo;

            _context.Entry(post).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent(); // Retorna 204 No Content, indicando sucesso sem corpo de resposta
        }

        /// <summary>
        /// Deleta um post.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePost(int id)
        {
            var post = await _context.Posts.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }

            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}