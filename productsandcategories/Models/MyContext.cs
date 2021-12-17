using Microsoft.EntityFrameworkCore;
using productsandcategories.Model;

namespace productsandcategories.Model
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) {}

        public DbSet<Categories> Categories {get; set;}

        public DbSet<Products> Products {get; set;}

        public DbSet<Associations> Associations {get; set;}

    }
}