namespace LivroCRUDNET.Models
{
    public class Livro
    {
        public Guid Id { get; set; }

        public string? Titulo { get; set; }

        public string? Autor { get; set; }

        public string? AnoPublicacao { get; set; }

        public Guid GeneroId { get; set; }
    }
}
