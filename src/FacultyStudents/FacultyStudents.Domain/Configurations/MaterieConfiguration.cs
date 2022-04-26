using FacultyStudents.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FacultyStudents.Domain.Configurations
{
    internal class MaterieConfiguration : IEntityTypeConfiguration<Materia>
    {
        public void Configure(EntityTypeBuilder<Materia> builder)
        {

            builder.HasKey(property => property.ID);

            builder
                .Property(property => property.NUME)
                .HasMaxLength(64)
                .IsRequired();

            builder
                .Property(property => property.NIVEL)
                .HasMaxLength(64)
                .IsRequired();

            builder
                .HasMany(entity => entity.Note)
                .WithOne(entity => entity.Materia)
                .HasForeignKey(property => property.MATERIAID);

            builder
                .HasMany(entity => entity.SpecializareMaterii)
                .WithOne(entity => entity.Materie)
                .HasForeignKey(property => property.MaterieId);
        }
    }
}
