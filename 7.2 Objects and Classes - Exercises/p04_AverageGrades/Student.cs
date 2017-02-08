using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_AverageGrades
{
    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }

        public double AverageGrades
        {
            get { return Grades.Average(); }
        }
    }
}
