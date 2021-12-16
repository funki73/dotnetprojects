using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace productsandcategories.Model
{
    public class Products
    {
        [Key]
        [Required]
        public int ProductId {get;set;}

        [Required]
        public string Name {get;set;}
        
        [Required]
        public string Description {get;set;}
        
        [Required]
        public int Price {get;set;}

        public DateTime CreatedAt = DateTime.Now;
        public DateTime UpdatedAt = DateTime.Now;

        [NotMapped]
        public List<Categories> AllCategories {get; set;}
    }
}