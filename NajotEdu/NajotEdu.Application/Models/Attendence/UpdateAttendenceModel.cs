namespace NajotEdu.Application.Models.Attendence
{
    public class UpdateAttendenceModel
    {
        public int Id { get; set; }
        public DateTime JoinedDate { get; set; }
        public int StudentId { get; set; }
        public int LessonId { get; set; }
    }
}
