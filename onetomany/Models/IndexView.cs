using System;
using onetomany.Models;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace onetomany.Models
{
    public class IndexView
    {
        public List<Chef> AllChefs {get; set;}
        public List<Dish> AllDishes {get; set;}

    }
}