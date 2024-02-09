using Assignment.Models;
using Microsoft.EntityFrameworkCore;
namespace Assignment.DB
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {
            
        }
        public AppDbContext(DbContextOptions options):base(options)
        {

            
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
