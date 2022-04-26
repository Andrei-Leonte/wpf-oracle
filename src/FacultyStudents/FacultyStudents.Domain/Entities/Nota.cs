using FacultyStudents.Domain.Entities.Base;

namespace FacultyStudents.Domain.Entities
{
    internal class Nota : BaseEntity<int>
    {
        public short NIVEL { get; set; }
        public int MATERIAID { get; set; }
        public int STUDENTID { get; set; }

        public Materia? Materia { get; set; }
        public Student? Student { get; set; }
    }
}
