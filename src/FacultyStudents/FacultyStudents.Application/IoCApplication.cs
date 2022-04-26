using FacultyStudents.Application.Interafaces.Services;
using FacultyStudents.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FacultyStudents.Application
{
    internal static class IoCApplication
    {
        public static void ApplicationRegister(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IStudentService, StudentService>();
            serviceCollection.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
