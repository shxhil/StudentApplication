﻿namespace StudentEnrolment.data
{
    public class Enrollment : BaseEntity
    {
        public int StudentId { get; set; }
        public int CourseID { get; set; }
        public virtual Course course { get; set; }

        public virtual Student student { get; set; }

    }
}


