using WebApplication2.Models;
using System.Collections.Generic;

namespace WebApplication2.Services
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        Student GetStudentById(int id);
    }
}
