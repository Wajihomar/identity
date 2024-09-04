using System.ComponentModel.DataAnnotations;

namespace identity.Models.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        [MaxLength(50)]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        [MaxLength(50)]
        [DataType(DataType.Password)]
       
        public string Password { get; set; }
    public bool RememberMe { get; set; }

    }
}
