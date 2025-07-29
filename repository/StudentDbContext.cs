using Microsoft.EntityFrameworkCore;
using studentcrudop.Model; // ✅ Corrected namespace

namespace studentcrudop.repository
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

