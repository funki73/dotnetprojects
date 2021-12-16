using System;
using productsandcategories;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace productsandcategories.Model
{
    public class Categories
    {
        [Key]
        public int CategoryId {get;set;}

        [Display(Name = "Name: ")]
        [Required]
        public string Name {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        [NotMapped]
        public List<Products> AllProducts {get; set;}
    }
}