using FacultyStudents.Infrastructure.Interfaces.Repositories;
using FacultyStudents.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace FacultyStudents.Infrastructure
{
    internal static class IoCInfrastructure
    {
        public static void InfrastructureRegister(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IStudentRepository, StudentRepository>();
        }
    }
}
