﻿namespace ContosoUniversity22.Models {
    public enum Grade {
        A,B,C,D,E
    }
    public class Enrollment {
        public int EnrollmentID { get; set; }
        public int CurseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}