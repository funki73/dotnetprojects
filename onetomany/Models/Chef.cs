using System;
using onetomany;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace onetomany.Models
{
    public class Chef
    {
        [Key]
        public int ChefId { get; set; }

        [Display(Name = "First Name: " )]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name: " )]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Date of Birth" )]
        [Required]
        [DataType(DataType.Date)]
        public DateTime Dateofbirth { get; set; }
        public List<Dish> CreatedDishes {get; set; }

        public int DishId {get; set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpatedAt { get; set; } = DateTime.Now;

        }
}