using WebApplication2.Models;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication2.Services
{
    public class StudentService : IStudentService
    {
        //private static readonly List<Student> _students = new()
        //{
        //    new Student { StudentId = 1, Name = "John", Age = 20, Grade = "A" },
        //    new Student { StudentId = 2, Name = "Alice", Age = 21, Grade = "B" },
        //    new Student { StudentId = 3, Name = "Karan", Age = 22, Grade = "A+" }
        //};

        private readonly StudentDbContext _studentDbContext;

        public StudentService(StudentDbContext studentDbContext)
        {
            _studentDbContext = studentDbContext;
        }

        public List<Student> GetStudents()
        {
            // Correct way to fetch all records from the Students table
            return _studentDbContext.Students.ToList();
        }

        public Student GetStudentById(int id)
        {
            // Fetch student by ID directly from the database
            return _studentDbContext.Students.FirstOrDefault(s => s.StudentId == id);
        }

        public void AddStudent(Student student)
        {
            _studentDbContext.Students.Add(student);
            _studentDbContext.SaveChanges();
        }
    }
}
