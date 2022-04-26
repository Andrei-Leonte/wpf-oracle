using FacultyStudents.Domain.Entities.Base;

namespace FacultyStudents.Domain.Entities
{
    internal class SpecializareMateria : BaseEntity<int>
    {
        public int MaterieId { get; set; }
        public int SpecializareId { get; set; }

        public Materia? Materie { get; set; }
        public Specializare? Specializare { get; set; }
    }
}
