using FacultyStudents.Domain.Entities;

namespace FacultyStudents.Application.Interafaces.Services
{
    internal interface IStudentService
    {
        Task<IEnumerable<Student>> GetAllAsync();
    }
}
