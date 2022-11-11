using System.ComponentModel.DataAnnotations;

namespace MarcaPonto.Model.Users
{
    public  class CustomerViewModel
    {
        [Key]
        public string Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(11)]
        public string CPF { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        public string Role { get; set; }
    }
}
