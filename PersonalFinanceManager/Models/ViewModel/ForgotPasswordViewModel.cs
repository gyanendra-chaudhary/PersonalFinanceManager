using System.ComponentModel.DataAnnotations;

namespace PersonalFinanceManager.Models.ViewModel
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
