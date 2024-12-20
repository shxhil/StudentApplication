﻿namespace StudentEnrolment.data
{
    public abstract class BaseEntity
    {
        public int id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string createdBy { get; set; } = string.Empty;
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; } = string.Empty;

    }
}


