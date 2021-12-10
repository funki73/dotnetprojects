using Microsoft.EntityFrameworkCore;
using registration_login.Models;

namespace registration_login.Models
{ 
    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}