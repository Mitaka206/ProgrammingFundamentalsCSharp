using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_AverageGrades
{
    class p04_AverageGrades
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] inputTokens = Console.ReadLine().Split();
                string sudentName = inputTokens[0];

                List<double> grades = new List<double>();
                for (int j = 1; j < inputTokens.Length; j++)
                {
                    double grade = double.Parse(inputTokens[j]);
                    grades.Add(grade);
                }

                Student student = new Student();
                student.Name = sudentName;
                student.Grades = grades;

                students.Add(student);
            }

            foreach (Student student in students.Where(s => s.AverageGrades >= 5).OrderBy(s => s.Name).ThenByDescending(s => s.AverageGrades))
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrades:F2}");
            }
        }
    }
}
