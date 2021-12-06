using System;
using dojo_survey_with_models.Controllers;
using System.ComponentModel.DataAnnotations;

namespace dojo_survey_with_models.Controllers
{
    public class Survey
    {
        [Display(Name = "Name: " )]
        [MinLength(2)]
        public string Name {get;set;}
        
        [Display(Name = "Favorite Language: " )]
        [Required]
        public string Favoritelanguage {get;set;}
        
        [Display(Name = "Dojo Location: " )]
        [Required]
        public string Dojolocation {get;set;}
        
        [Display(Name = "Comments: " )]
        [MinLength(2)]
        public string Comments {get;set;}

        public Survey () {}

        public Survey(string name, string favoritelanguage, string dojolocation, string comments)
        {
            Name = name;
            Favoritelanguage = favoritelanguage;
            Dojolocation = dojolocation;
            Comments = comments;
        }
    }
}