using FacultyStudents.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FacultyStudents.Infrastructure.Contexts
{
    internal class FacultyDBContext : DbContext
    {
        public FacultyDBContext() { }

        public FacultyDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Specializare> Specializari { get; set; }
        public DbSet<Materia> Materii { get; set; }
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Nota> Note { get; set; }
        public DbSet<SpecializareMateria> SpecializareMaterii { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle(@"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=xe)));User Id=smith;Password=password;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Specializare>().ToTable("Specializari");
            modelBuilder.Entity<Materia>().ToTable("Materii");
            modelBuilder.Entity<Student>().ToTable("STUDENTI");
            modelBuilder.Entity<Nota>().ToTable("Note");
            modelBuilder.Entity<SpecializareMateria>().ToTable("SpecializareMaterii");
        }
    }
}
