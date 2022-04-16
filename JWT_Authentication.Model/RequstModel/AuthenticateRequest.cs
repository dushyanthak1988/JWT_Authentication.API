using System.ComponentModel.DataAnnotations;

namespace JWT_Authentication.Models.RequstModel
{
    public class AuthenticateRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
