namespace NajotEdu.Domain.Entities
{
    public class Student
    {
        public Student()
        {
            Groups = new HashSet<StudentGroup>();
            Attenants = new HashSet<Attendance>();
        }
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<Attendance> Attenants { get; set; }
        public ICollection<StudentGroup> Groups { get; set; }

    }
}
