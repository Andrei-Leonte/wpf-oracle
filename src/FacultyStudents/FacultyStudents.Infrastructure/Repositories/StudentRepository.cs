using FacultyStudents.Domain.Entities;
using FacultyStudents.Infrastructure.Contexts;
using FacultyStudents.Infrastructure.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FacultyStudents.Infrastructure.Repositories
{
    internal class StudentRepository : IStudentRepository
    {
        private readonly FacultyDBContext facultyDBContext;

        public StudentRepository()
        {
            facultyDBContext = new FacultyDBContext();
        }

        public async Task<IEnumerable<Student>> GetAllAsync()
        {
            return await facultyDBContext
                .Studenti
                .ToListAsync();
        }
    }
}
