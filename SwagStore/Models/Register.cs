using System.ComponentModel.DataAnnotations;

namespace SwagStore.Models
{
    public class Register
    {
        [Key]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public string Password { get; set; }
        

    }
}
