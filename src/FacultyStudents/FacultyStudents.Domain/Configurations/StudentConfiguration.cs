using FacultyStudents.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FacultyStudents.Domain.Configurations
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(property => property.ID);

            builder
                .Property(property => property.NUME)
                .HasMaxLength(64)
                .IsRequired();

            builder
                .Property(property => property.PRENUME)
                .HasMaxLength(64)
                .IsRequired();

            builder
                .Property(property => property.TELEFON)
                .HasMaxLength(16)
                .IsRequired();
        }
    }
}
