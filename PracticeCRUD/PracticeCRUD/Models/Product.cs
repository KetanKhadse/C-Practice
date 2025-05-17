using System.ComponentModel.DataAnnotations;

namespace PracticeCRUD.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display (Name ="ProductName")]
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public string? Color { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string? image {  get; set; }
        public int CategoryId {  get; set; }
    }
}
