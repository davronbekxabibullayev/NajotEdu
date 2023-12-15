namespace NajotEdu.Domain.Entities
{
    public class Attendance
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public virtual Student? Student { get; set; }
        public int LessonId { get; set; }
        public virtual Lesson? Lesson { get; set; }
        public bool HasParticipated { get; set; }
    }
}