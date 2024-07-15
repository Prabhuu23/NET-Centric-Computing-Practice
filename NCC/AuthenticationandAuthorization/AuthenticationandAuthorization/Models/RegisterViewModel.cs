using System.ComponentModel.DataAnnotations;

namespace AuthenticationandAuthorization.Models
{
    public class RegisterViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
   
}
