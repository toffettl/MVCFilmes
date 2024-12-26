using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace MVCFilmes.Models
{
    public class Filmes
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Titulo { get; set; } = string.Empty;

        [Display(Name = "Data de lançamento")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }

        [
            Required(ErrorMessage = "Este campo é obrigatório"), 
            StringLength(10),
        ]
        public string Genero { get; set; } = string.Empty;

        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Preco {  get; set; }

        [Range(0,5)]
        public int? Pontos { get; set; }
    }
}
