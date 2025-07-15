using WebApplication2.Models;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication2.Services
{
    public class StudentService : IStudentService
    {
        private static readonly List<Student> _students = new()
        {
            new Student { StudentId = 1, Name = "John", Age = 20, Grade = "A" },
            new Student { StudentId = 2, Name = "Alice", Age = 21, Grade = "B" },
            new Student { StudentId = 3, Name = "Karan", Age = 22, Grade = "A+" }
        };

        public List<Student> GetStudents()
        {
            return _students;
        }

        public Student GetStudentById(int id)
        {
            return _students.FirstOrDefault(s => s.StudentId == id);
        }
    }
}
