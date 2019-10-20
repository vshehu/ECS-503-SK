using System;
using System.Collections.Generic;

namespace StudentTranscript.Update
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> courses = new List<string>();
            List<int> credits = new List<int>();
            List<int> grades = new List<int>();
            
            while (true)
            {
                Console.WriteLine("Ju lutem shkruani emrin e lendes, ose shkruani X per te vazhduar!");
                string courseName = Console.ReadLine();
                if (courseName == "X" || courseName == "x")
                    break;

                courses.Add(courseName);

                int grade, credit;
                Console.WriteLine("Ju lutem shkruani noten per kete lende:  " + courseName);
                string stringGrade = Console.ReadLine().ToLower();

                if (stringGrade == "in") stringGrade = "-1";
                else if (stringGrade == "nr") stringGrade = "-2";
                
                grade = Convert.ToInt32(stringGrade);
                
                while ((grade != -2 && grade != -1) && (grade < 5 || grade > 10))
                {
                    Console.WriteLine("Notat duhet te jene te rangut 5-10, IN ose NR: " + courseName);
                    stringGrade = Console.ReadLine().ToLower();
                    
                    if (stringGrade == "in") stringGrade = "-1";
                    else if (stringGrade == "nr") stringGrade = "-2";
                    
                    grade = Convert.ToInt32(stringGrade);
                }

                Console.WriteLine("Ju lutem shkruani kreditet per kete lende: " + courseName);
                credit = Convert.ToInt32(Console.ReadLine());
                while (credit < 1 || credit > 10)
                {
                    Console.WriteLine("Kreditet duhet te jete nga numri 1 deri ne 10: " + courseName);
                    credit = Convert.ToInt32(Console.ReadLine());
                }

                credits.Add(credit);
                grades.Add(grade);
            }

            Console.WriteLine("        TRANSKRIPTA E STUDENTIT");
            Console.WriteLine("=======================================");
            Console.WriteLine("| LENDA \t KREDITE \t NOTA");
            Console.WriteLine("=======================================");
            double shumaKredive = 0;
            double totalKredit = 0;
            double shumaNotave = 0;

            for (var i = 0; i < courses.Count; i++)
            {
                Console.WriteLine(courses[i] + "\t\t" + credits[i] + "\t\t" + GradeString(grades[i]));

                totalKredit += credits[i];

                int grade = grades[i];
                if (grade != -2 && grade != -1 && grade != 5)
                {
                    shumaKredive += credits[i];
                    shumaNotave += credits[i] * grades[i];
                }
            }

            double gpa = 0;

            if (shumaKredive != 0) gpa = shumaNotave / shumaKredive;

            Console.WriteLine("=====================================");
            Console.WriteLine("Credits attempted: " + totalKredit);
            Console.WriteLine("Credits awarded: " + shumaKredive);
            Console.WriteLine("Number of courses: " + courses.Count);
            Console.WriteLine("GPA: " + gpa.ToString("0.00"));
        }

        private static string GradeString(int grade)
        {
            if (grade == -1) return "IN";
            else if (grade == -2) return "NR";

            return grade.ToString();
        }
    }
}