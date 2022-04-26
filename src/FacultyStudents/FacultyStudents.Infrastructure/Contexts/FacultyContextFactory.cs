using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FacultyStudents.Infrastructure.Contexts
{
    internal class FacultyContextFactory : IDesignTimeDbContextFactory<FacultyDBContext>
    {
        public FacultyDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FacultyDBContext>();
            optionsBuilder
                .UseOracle(@"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=xe)));User Id=smith;Password=password;");

            return new FacultyDBContext(optionsBuilder.Options);
        }
    }
}