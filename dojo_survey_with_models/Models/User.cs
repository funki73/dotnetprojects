using System;
using dojo_survey_with_models.Models;

namespace dojo_survey_with_models.Controllers
{
    public class Survey
    {
        public string Name {get;set;}
        public string Favoritelanguage {get;set;}
        public string Dojolocation {get;set;}
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