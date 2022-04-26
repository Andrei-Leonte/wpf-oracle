using FacultyStudents.Application;
using FacultyStudents.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace FacultyStudents
{
    internal static class Startup
    {
        public static ServiceProvider UseStartup(this MainWindow mainWindow)
        {
            ServiceCollection services = new ServiceCollection();
            
            services.InfrastructureRegister();
            services.ApplicationRegister();

            return services.BuildServiceProvider();
        }
    }
}
