using EnrollmentSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EnrollmentSystem.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Student> Students { get; set; }
    }
}
