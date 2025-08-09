using System.ComponentModel.DataAnnotations;
using Microsoft.Identity.Client;

namespace PersonalFinanceManager.Models.ViewModel
{
    public class SigninViewModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }= string.Empty;

        [Display(Name ="Remember Me")]
        public bool RememberMe { get; set; }
    }
}
