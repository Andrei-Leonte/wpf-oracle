using FacultyStudents.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FacultyStudents.Domain.Configurations
{
    internal class NotaConfiguration : IEntityTypeConfiguration<Nota>
    {
        public void Configure(EntityTypeBuilder<Nota> builder)
        {
            builder.HasKey(property => property.ID);

            builder
                .Property(property => property.NIVEL)
                .HasMaxLength(10)
                .IsRequired();
        }
    }
}
