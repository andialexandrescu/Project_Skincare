using System.ComponentModel.DataAnnotations;

namespace Project_Skincare.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "The product title is required")]
        public string Description { get; set; }
        [Required(ErrorMessage = "The description is required")]
        public string Content { get; set; }
        public DateTime DateListed { get; set; }
        [Required(ErrorMessage = "Adding the product category is required")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}