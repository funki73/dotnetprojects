using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace productsandcategories.Model
{
    public class Associations
    {
        [Key]
        public int AssociationId {get;set;}

        public int ProductId {get;set;}

        public int CategoryId {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        
    }
}