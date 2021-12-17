using System.Collections.Generic;

namespace productsandcategories.Model
{
    public class Productview
    {
        public Products ToRender { get; set; }

        public List<Categories> ToAdd { get; set; }

        public Associations AddCategory { get; set; }

    }
}