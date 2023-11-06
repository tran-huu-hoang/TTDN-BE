using Lab06_ex.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab06_ex.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<StdClass> StdClasses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<Marks> Marks { get; set; }
    }
}
