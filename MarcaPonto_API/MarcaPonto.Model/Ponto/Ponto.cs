using System.ComponentModel.DataAnnotations;

namespace MarcaPonto.Model.Ponto
{
    public class Ponto
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string DataCadastro { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public bool Active { get; set; } = true;
    }
}