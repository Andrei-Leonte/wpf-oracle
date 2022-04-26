using FacultyStudents.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FacultyStudents.Domain.Configurations
{
    internal class SpecializareMateriaConfiguration : IEntityTypeConfiguration<SpecializareMateria>
    {
        public void Configure(EntityTypeBuilder<SpecializareMateria> builder)
        {
            builder.HasKey(property => property.ID);
        }
    }
}
