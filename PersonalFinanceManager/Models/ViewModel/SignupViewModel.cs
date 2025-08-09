using System.ComponentModel.DataAnnotations;

namespace PersonalFinanceManager.Models.ViewModel
{
    public class SignupViewModel
    {
        // Personal Information
        [Required]
        [StringLength(50)]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string? LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        // Contact Information
        [Required]
        [EmailAddress]
        public string? Email { get; set; } 

        public string? PhoneNumber { get; set; }

        // Address Information
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }

        // Account Information
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string? ConfirmPassword { get; set; }

        // Preferences
        [StringLength(3)]
        public string CurrencyPreference { get; set; } = "USD";

        [Display(Name = "Profile Picture")]
        public IFormFile? ProfilePicture { get; set; }

        public bool IsTwoFactorEnabled { get; set; }
        public string NotificationPreferences { get; set; } = "Email";

        [Range(0, double.MaxValue)]
        public decimal? MonthlyBudgetGoal { get; set; }

        [Range(0, double.MaxValue)]
        public decimal? SavingsGoal { get; set; }

        public bool PrefersDarkMode { get; set; }

        // Additional fields from ApplicationUser
        public bool IsActive { get; set; } = true;
        public DateTime? RegistrationDate { get; set; } = DateTime.UtcNow;
        public DateTime? LastLoginDate { get; set; }
    }
}
