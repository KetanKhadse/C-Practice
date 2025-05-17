using System.ComponentModel.DataAnnotations;

namespace CrudWithoutEntity.Models
{
    public class UserClass
    {
        [Key]
        public int Id { get; set; }
        public string? FirstName {  get; set; }
        public string? LastName {  get; set; }
        public string? Email {  get; set; }
        public string? Password {  get; set; }
        public int IsActive {  get; set; } = 1;
    }
}
