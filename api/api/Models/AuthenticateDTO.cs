using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class AuthenticateDTO
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
    }
}
