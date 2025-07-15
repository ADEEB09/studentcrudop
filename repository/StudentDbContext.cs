using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

public class StudentDbContext : DbContext
{
    public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
    {
    }

    public DbSet<Student> Students { get; set; }
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseSqlServer(
    //        @"Server=localhost;Database=StudentDb;Trusted_Connection=True;");
    //}

}
