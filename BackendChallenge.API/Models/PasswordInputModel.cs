using System.ComponentModel.DataAnnotations;

namespace BackendChallenge.API.Models.InputModels
{
    public class PasswordInputModel
    {
        [Required]
        public string Password { get; set; }
    }
}
