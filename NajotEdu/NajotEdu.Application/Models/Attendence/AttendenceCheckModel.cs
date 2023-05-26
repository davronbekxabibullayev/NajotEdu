namespace NajotEdu.Application.Models.Attendence
{
    // bu yerda student kelgani yoki yuqligini saqlaydigan model
    public class AttendenceCheckModel
    {
        public int StudentId { get; set; }
        public bool HasParticipated { get; set; }
    }
}
