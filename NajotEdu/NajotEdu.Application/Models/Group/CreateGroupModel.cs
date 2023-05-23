namespace NajotEdu.Application.Models
{
    public class CreateGroupModel
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TeacherId { get; set; }
        public TimeOnly LessonStartTime { get; set; }
        public TimeOnly LessonEndTime { get ; set; }
    }
}
