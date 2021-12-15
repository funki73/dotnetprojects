using System;
using onetomany;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace onetomany.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }

        [Display(Name = "Name of Dish: " )]
        [Required]
        public string DishName { get; set; }

        [Display(Name = "Number of Calories: " )]
        [Required]
        [Range(0, 10000)]
        public int NumCalories { get; set; }

        [Display(Name = "Description: " )]
        [Required]
        public string Description { get; set; }

        [Display(Name = "Tastiness: " )]
        [Required]
        [Range(1, 5)]
        public int Tastiness { get; set; }
        public int ChefId { get; set; }
        public Chef Creator {get;set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [NotMapped]
        public List<Chef> AllChefs {get;set;}

        }
}