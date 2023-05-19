namespace NajotEdu.Domain.Entities
{
    public class Attendence
    {
        public int Id { get; set; }
        public DateTime JoinedDate { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }
    }
}
