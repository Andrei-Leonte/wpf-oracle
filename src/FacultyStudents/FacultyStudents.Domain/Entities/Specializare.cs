using FacultyStudents.Domain.Entities.Base;

namespace FacultyStudents.Domain.Entities
{
    internal class Specializare : BaseEntity<int>
    {
        public Specializare()
        {
            SpecializareMaterii = new List<SpecializareMateria>();
            Studenti = new List<Student>();
        }

        public string? NUME { get; set; }

        public IEnumerable<SpecializareMateria> SpecializareMaterii { get; set; }
        public IEnumerable<Student> Studenti { get; set; }
    }
}
