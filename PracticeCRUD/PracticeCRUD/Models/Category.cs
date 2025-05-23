﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PracticeCRUD.Models
{
    public class Category
    {
        [Key]
        public int CategoryId {  get; set; }
        [Required]
        [Display (Name ="Category Name")]
        public string? CategoryName { get; set; }
    }
}
