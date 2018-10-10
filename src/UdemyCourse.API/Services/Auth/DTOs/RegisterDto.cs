using System.ComponentModel.DataAnnotations;

namespace UdemyCourse.API.Services.Auth.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "Password must be 6 characters")]
        public string Password { get; set; }
    }
}