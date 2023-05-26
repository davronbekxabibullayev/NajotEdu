namespace NajotEdu.Application.Models.Lesson
{
    public class LessonModel
    {
        public int Id { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int GroupId { get; set; }
    }
}
