using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace PersonalFinanceManager.Models.Entity
{
    public class ApplicationUser:IdentityUser
    {
        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty;

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [StringLength(100)]
        public string? Address { get; set; }

        [StringLength(50)]
        public string? City { get; set; }

        [StringLength(50)]
        public string? State { get; set; }

        [StringLength(20)]
        [Display(Name = "Postal Code")]
        public string? PostalCode { get; set; }

        [StringLength(50)]
        public string? Country { get; set; }

        [Display(Name = "Currency Preference")]
        [StringLength(3)]
        public string CurrencyPreference { get; set; } = "USD";

        [Display(Name = "Profile Picture")]
        public byte[]? ProfilePicture { get; set; }

        [Display(Name = "Two Factor Enabled")]
        public bool IsTwoFactorEnabled { get; set; }

        [Display(Name = "Notification Preferences")]
        public string? NotificationPreferences { get; set; }

        [Display(Name = "Registration Date")]
        public DateTime? RegistrationDate { get; set; } = DateTime.UtcNow;

        [Display(Name = "Last Login Date")]
        public DateTime? LastLoginDate { get; set; }

        [Display(Name = "Account Status")]
        public bool IsActive { get; set; } = true;

        [Display(Name = "Monthly Budget Goal")]
        [Range(0, double.MaxValue)]
        public decimal? MonthlyBudgetGoal { get; set; }

        [Display(Name = "Savings Goal")]
        [Range(0, double.MaxValue)]
        public decimal? SavingsGoal { get; set; }

        [Display(Name = "Dark Mode Preference")]
        public bool PrefersDarkMode { get; set; }
        public ICollection<Expense> Expenses { get; set; } = new List<Expense>();
        public ICollection<Income> Incomes { get; set; } = new List<Income>();
        public ICollection<Category> Categories { get; set; } = new List<Category>();
    }
}
