﻿namespace NajotEdu.Domain.Entities
{
    public class Student
    {
        public Student()
        {
            Groups = new HashSet<StudentGroup>();
            Attenants = new HashSet<Attendence>();
        }
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTimeOffset Birthdate { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<Attendence> Attenants { get; set; }
        public ICollection<StudentGroup> Groups { get; set; }

    }
}
