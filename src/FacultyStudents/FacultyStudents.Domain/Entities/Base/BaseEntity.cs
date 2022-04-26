namespace FacultyStudents.Domain.Entities.Base
{
    internal abstract class BaseEntity<T>
        where T : struct
    {
        public T ID { get; set; }
    }
}
