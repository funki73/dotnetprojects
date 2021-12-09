using System;
using crudelicious;
using System.ComponentModel.DataAnnotations;

namespace crudelicious.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }

        [Display(Name = "Chefe's Name: " )]
        [Required]
        public string Chef { get; set; }
        
        [Display(Name = "Name of Dish: " )]
        [Required]
        public string DishName { get; set; }
        
        [Display(Name = "Tastiness: " )]
        [Required]
        public int Tastiness { get; set; }

        [Display(Name = "Number of Calories: " )]
        [Required]
        public string NumCalories { get; set; }
        
        [Display(Name = "Description: " )]
        [Required]
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpatedAt { get; set; } = DateTime.Now;

        }
}