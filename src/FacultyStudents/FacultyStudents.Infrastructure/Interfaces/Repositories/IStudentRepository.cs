using FacultyStudents.Domain.Entities;

namespace FacultyStudents.Infrastructure.Interfaces.Repositories
{
    internal interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAllAsync();
    }
}
