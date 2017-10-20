using System;
using System.Collections.Generic;

namespace _08.MentorGroup
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, List<string>>> students =
                new SortedDictionary<string, Dictionary<string, List<string>>>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end of dates")
                {
                    break;
                }

                string[] dateInfo = command.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string studentName = dateInfo[0];

                List<string> dates = new List<string>();
                for (int i = 1; i < dateInfo.Length; i++)
                {
                    dates.Add(dateInfo[i]);
                }

                if (!students.ContainsKey(studentName))
                {
                    students[studentName] = new Dictionary<string, List<string>>() { { "dates", new List<string>() }, { "comments", new List<string>() } };
                }

                students[studentName]["dates"].AddRange(dates);
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end of comments")
                    break;

                string[] commentInfo = command.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                string studentName = commentInfo[0];

                if (!students.ContainsKey(studentName))
                    continue;
                string comment = commentInfo[1];

                students[studentName]["comments"].Add(comment);
            }

            foreach (var student in students)
            {
                Console.WriteLine(student.Key);

                Console.WriteLine("Comments:");
                foreach (var comment in student.Value["comments"])
                {
                    Console.WriteLine($"- {comment}");
                }

                student.Value["dates"].Sort();
                Console.WriteLine("Dates attended:");
                foreach (var date in student.Value["dates"])
                {
                    Console.WriteLine($"-- {date}");
                }
            }
        }
    }
}