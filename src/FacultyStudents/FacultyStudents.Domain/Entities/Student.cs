using FacultyStudents.Domain.Entities.Base;

namespace FacultyStudents.Domain.Entities
{
    internal class Student : BaseEntity<int>
    {
        public Student()
        {
            Note = new List<Nota>();
        }

        public int SPECIALIZAREID { get; set; }
        public string? NUME { get; set; }
        public string? PRENUME { get; set; }
        public string? TELEFON { get; set; }

        public Specializare? Specializare { get; set; }
        public IEnumerable<Nota> Note { get; set; }
    }
}
