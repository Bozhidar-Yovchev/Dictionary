using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of students:");
            int n = int.Parse(Console.ReadLine());
            var grades = new Dictionary<string, List<double>>();
            Console.WriteLine("Enter name and grade:");
            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();
                var name = tokens[0];
                var grade = double.Parse(tokens[1]);

                if (!grades.ContainsKey(name))
                {
                    grades[name] = new List<double>();
                }
                grades[name].Add(grade);
            }

            foreach (var pair in grades)
            {
                var name = pair.Key;
                var studentGrade = pair.Value;
                var average = studentGrade.Average();


                Console.Write($"{name} -> ");
                foreach (var grade in studentGrade)
                {
                    Console.Write($"{grade:f2} ");
                    Console.WriteLine($"avg: {average:f2}");
                }
            }
        }
    }
}
