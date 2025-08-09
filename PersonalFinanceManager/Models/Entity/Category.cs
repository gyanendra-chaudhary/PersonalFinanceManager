using System.ComponentModel.DataAnnotations;

namespace PersonalFinanceManager.Models.Entity
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public CategoryType Type { get; set; }
        [Required]
        public string UserId { get; set; } = string.Empty;
        public ApplicationUser User { get; set; } = new ApplicationUser();
    }
    public enum CategoryType
    {
        Income,
        Expense
    }
}
