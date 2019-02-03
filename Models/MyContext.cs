using Microsoft.EntityFrameworkCore;
 
namespace restauranter.Models
{
    public class MyContext : DbContext
    {
        public DbSet<Review> Review { get; set; }
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }
    }
}