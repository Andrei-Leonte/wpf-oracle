using FacultyStudents.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FacultyStudents.Domain.Configurations
{
    internal class SpecializareConfiguration : IEntityTypeConfiguration<Specializare>
    {
        public void Configure(EntityTypeBuilder<Specializare> builder)
        {
            builder.HasKey(property => property.ID);

            builder
                .Property(property => property.NUME)
                .HasMaxLength(64)
                .IsRequired();

            builder
                .HasMany(entity => entity.Studenti)
                .WithOne(entity => entity.Specializare)
                .HasForeignKey(property => property.SPECIALIZAREID);

            builder
                .HasMany(entity => entity.SpecializareMaterii)
                .WithOne(entity => entity.Specializare)
                .HasForeignKey(property => property.SpecializareId);
        }
    }
}
