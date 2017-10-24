using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _04.AverageGrades
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            String[] inputFile = File.ReadAllLines("input.txt");
            File.Delete("output.txt");

            int n = int.Parse(inputFile[0]);

            List<Student> students = new List<Student>();

            for (int i = 1; i <= n; i++)
            {
                Student student = new Student();
                string[] input = inputFile[i].Split(' ');

                student.Name = input[0];
                student.Grades = input.Skip(1).Select(double.Parse).ToList();

                students.Add(student);
            }

            File.WriteAllText("output.txt", "");

            List<Student> sortedStudents = students
                .Where(s => s.Average >= 5.00)
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.Average)
                .ToList();

            foreach (var student in sortedStudents)
            {
                string output = $"{student.Name} -> {student.Average:F2}" + Environment.NewLine;
                File.AppendAllText("output.txt", output);
            }
        }
    }

    internal class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double Average => Grades.Average();
    }
}