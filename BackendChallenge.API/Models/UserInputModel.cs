using System.ComponentModel.DataAnnotations;

namespace BackendChallenge.API.Models
{
    public class UserInputModel
    {
        [Required]
        public string Password { get; set; }
    }
}
