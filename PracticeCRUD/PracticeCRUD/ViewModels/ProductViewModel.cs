using System.ComponentModel.DataAnnotations;

namespace PracticeCRUD.ViewModels
{
    public class ProductViewModel
    {
        
        public int Id { get; set; }
        
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public string? Color { get; set; }
   
        public int Price { get; set; }
     
        public string? image { get; set; }
        public int CategoryId { get; set; }
    }
}
