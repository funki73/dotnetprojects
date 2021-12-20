using Microsoft.EntityFrameworkCore;

namespace belt_exam
{ 
    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}