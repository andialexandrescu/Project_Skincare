using System.ComponentModel.DataAnnotations;

namespace Project_Skincare.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "The category name must be specified")]
        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}
