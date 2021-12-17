using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace productsandcategories.Model
{
    public class Associations
    {
        [Key]
        public int AssociationId {get;set;}

        [ForeignKey("ProdwithCat")]
        public int ProductId {get;set;}

        public Products ProdwithCat {get;set;}
        [ForeignKey("CatwithProd")]
        public int CategoryId {get;set;}

        public Categories CatwithProd {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}