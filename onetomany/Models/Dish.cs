using System;
using onetomany;
using System.Collections;
using System.ComponentModel.DataAnnotations;

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
        [Range(0, 500)]
        public int NumCalories { get; set; }

        [Display(Name = "Description: " )]
        [Required]
        public string Description { get; set; }

        [Display(Name = "Chefe's Name: " )]
        [Required]
        public string Chef { get; set; }

        [Display(Name = "Tastiness: " )]
        [Required]
        public int Tastiness { get; set; }
        public int ChefId { get; set; }
        public Chef Creator {get;set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpatedAt { get; set; } = DateTime.Now;

        }
}