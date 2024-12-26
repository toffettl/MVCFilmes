using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCFilmes.Models
{
    public class FilmesViewModel
    {
        public List<Filmes> ? Filmes { get; set; }
        public SelectList ? Generos {  get; set; }
        public string ? Genero {  get; set; }
        public string ? texto { get; set; }
    }
}
