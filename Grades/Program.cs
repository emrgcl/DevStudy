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
            GradeBook MyGrades = new GradeBook();
            MyGrades.AddGrade(85);
            MyGrades.AddGrade(75.5F);
            MyGrades.AddGrade(30);

            GradeStatistics stats = MyGrades.ComputeStatistics();
            Console.WriteLine("Lowest Grade: " + stats.LowestGrade);
            Console.WriteLine("Highest Grade: " + stats.HighestGrade);
            Console.WriteLine("Avarage Garade: " + stats.AvarageGrade);
        }
    }
}
