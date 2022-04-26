using AutoMapper;
using FacultyStudents.Application.Interafaces.Services;
using FacultyStudents.Domain.Entities;
using FacultyStudents.Infrastructure.Interfaces.Repositories;

namespace FacultyStudents.Application.Services
{
    internal class StudentService : IStudentService
    {
        private readonly IStudentRepository studentRepository;
        private readonly IMapper mapper;

        public StudentService(IStudentRepository studentRepository, IMapper mapper)
            => (this.studentRepository, this.mapper) = (studentRepository, mapper);

        public async Task<IEnumerable<Student>> GetAllAsync()
        {
            return await studentRepository.GetAllAsync();
        }
    }
}
