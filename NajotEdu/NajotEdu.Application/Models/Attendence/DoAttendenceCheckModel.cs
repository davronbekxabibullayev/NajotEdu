namespace NajotEdu.Application.Models.Attendence
{
    // Lesson ning hamma uquvchilari kelgan kelmaganini uzida saqlaydigan joy
    public class DoAttendenceCheckModel
    {
        public int LessonId { get; set; }
        public List<AttendenceCheckModel> Checks { get; set; }
    }
}
