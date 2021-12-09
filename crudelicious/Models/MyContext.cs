using Microsoft.EntityFrameworkCore;
using crudelicious.Models;

namespace crudelicious.Models

{ 
    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) {}

        public DbSet<Dish> Dishes { get; set; }
    }
}