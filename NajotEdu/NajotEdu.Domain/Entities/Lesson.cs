namespace NajotEdu.Domain.Entities
{
    public class Lesson
    {
        public Lesson()
        {
            Attenants = new HashSet<Attendence>();
        }
        public int Id { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public ICollection<Attendence> Attenants { get; set; }
    }
}
