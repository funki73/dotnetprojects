using System;
using crudelicious;
using System.ComponentModel.DataAnnotations;

namespace crudelicious
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }

        [Display(Name = "Chefe's Name: " )]
        public string Chef { get; set; }
        
        [Display(Name = "Name of Dish: " )]
        public string DishName { get; set; }
        
        [Display(Name = "Tastiness: " )]
        public int Tastiness { get; set; }

        [Display(Name = "Number of Calories: " )]
        public string NumCalories { get; set; }
        
        [Display(Name = "Description: " )]
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpatedAt { get; set; } = DateTime.Now;

        }
}