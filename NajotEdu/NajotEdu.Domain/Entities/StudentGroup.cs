﻿namespace NajotEdu.Domain.Entities
{
    public class StudentGroup
    {
        public int Id { get; set; }
        public DateTime JoinedDate { get; set; }
        public bool IsPayed { get; set; }
        public int StudentId { get; set; }
        public virtual Student? Student { get; set; }
        public int GroupId { get; set; }
        public virtual Group? Group { get; set; }

    }
}
