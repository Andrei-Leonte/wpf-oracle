using FacultyStudents.Domain.Entities.Base;

namespace FacultyStudents.Domain.Entities
{
    internal class Materia : BaseEntity<int>
    {
        public Materia()
        {
            SpecializareMaterii = new List<SpecializareMateria>();
            Note = new List<Nota>();
        }

        public string? NUME { get; set; }
        public short NIVEL { get; set; }

        public IEnumerable<SpecializareMateria> SpecializareMaterii { get; set; }
        public IEnumerable<Nota> Note { get; set; }
    }
}
