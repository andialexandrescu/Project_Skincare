using System.ComponentModel.DataAnnotations;

namespace Project_Skincare.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Must enter the review content")]
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

    }
}
