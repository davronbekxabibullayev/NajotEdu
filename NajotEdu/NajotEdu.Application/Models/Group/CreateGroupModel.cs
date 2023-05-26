namespace NajotEdu.Application.Models
{
    public class CreateGroupModel
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TeacherId { get; set; }
        public TimeSpan LessonStartTime { get; set; }
        public TimeSpan LessonEndTime { get; set; }
    }

}
