using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School
{
    public class Student
    {
        public string name;
        public int studentId;
        private readonly int numberOfCredits;
        private double gpa;
    }

    public class Course
    {
        public readonly int classId;
        public readonly string className;
        public Student[] enrolledStudents;

    }
}