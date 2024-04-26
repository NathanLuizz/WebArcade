using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebArcade.Models
{
    [Table("Games")]
    public class Games
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatorio informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a desenvolvedora")]
        public string Desenvolvedora { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o ano do lançamento")]
        public int Anolancamento { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o genero")]
        public string Genero { get; set; }
    }
}
