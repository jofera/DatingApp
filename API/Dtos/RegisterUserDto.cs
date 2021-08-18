using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class RegisterUserDto
    {
        [Required]
        [MinLength(3)]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4)]
        public string Password { get; set; }
    }
}
