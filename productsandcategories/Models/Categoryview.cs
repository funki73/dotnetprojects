using System.Collections.Generic;

namespace productsandcategories.Model
{
    public class Categoryview
    {
        public Categories ToRender { get; set; }

        public List<Products> ToAdd { get; set; }

        public Associations AddForm { get; set; }

    }
}