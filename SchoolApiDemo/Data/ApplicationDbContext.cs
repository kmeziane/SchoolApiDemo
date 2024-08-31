using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SchoolApiDemo.Models;

namespace SchoolApiDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Course>? Courses { get; set; }
        public DbSet<Student>? Students { get; set; }
    }
}
