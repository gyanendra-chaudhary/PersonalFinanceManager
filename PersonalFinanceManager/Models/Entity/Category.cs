using System.ComponentModel.DataAnnotations;

namespace PersonalFinanceManager.Models.Entity
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public CategoryType Type { get; set; }
        [Required]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
    public enum CategoryType
    {
        Income,
        Expense
    }
}
