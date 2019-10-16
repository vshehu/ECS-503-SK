using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml;

namespace SK.StudentTranscript
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> courses = new List<string>();
            List<int> grades = new List<int>();
            List<int> credits = new List<int>();
            
            courses.Add("test");
            grades.Add(10);
            credits.Add(10);
            
            while (true)
            {
                Console.WriteLine("Ju lutem shkruani emrin e lendes, ose shkruani X per te vazhduar!");
                string courseName = Console.ReadLine();
                if (courseName == "X" || courseName == "x")
                    break;

                courses.Add(courseName);

                Console.WriteLine("Ju lutem shkruani numrin e kredive per kete lende!");
                while (true)
                {
                    int credit;
                    if (int.TryParse(Console.ReadLine(), out credit) && credit >= 1 && credit <= 10)
                    {
                        credits.Add(credit);
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ju lutemi jepeni nje vlere prej 5-10!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                
                Console.WriteLine("Ju lutem shkruani noten per kete lende!");

                while (true) 
                {
                    var mGrade = Console.ReadLine();

                    switch (mGrade.ToLower())
                    {
                        case "in":
                            mGrade = "3";
                            break;
                        case "nr":
                            mGrade = "4";
                            break;
                    }

                    if (int.TryParse(mGrade, out var grade) && (grade >= 3 && grade <= 10))
                    {
                        grades.Add(grade);
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ju lutemi jepeni nje vlere prej 5-10!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }

            Console.WriteLine("        TRANSKRIPTA E STUDENTIT");
            Console.WriteLine("=======================================");
            Console.WriteLine("| LENDA \t\t KREDITE \t NOTA");
            Console.WriteLine("=======================================");
            double shumaKredive = 0;
            double totalKredit = 0;
            double shumaNotave = 0;
            for (var i = 0; i<courses.Count; i++)
            {
                Console.WriteLine(courses[i] + "\t\t" + credits[i] + "\t" + UserReadableGrade(grades[i]));

                totalKredit += credits[i];
                if (!(grades[i] >= 3 && grades[i] <= 5))  {
                    shumaKredive += credits[i];
                    shumaNotave += credits[i] * grades[i];
                }
            }
            double gpa = shumaNotave / shumaKredive;

            Console.WriteLine("=====================================");
            Console.WriteLine("Credits attempted: " + totalKredit);
            Console.WriteLine("Credits awarded: " + shumaKredive);
            Console.WriteLine("Number of courses: " + courses.Count);
            Console.WriteLine("GPA: " + gpa.ToString("0.00"));
        }
        
        private static string UserReadableGrade(int grade)
        {
            switch (grade)
            {
                case 3:
                    return "IN";
                case 4:
                    return "NR";
                default:
                    return grade.ToString();
            }
        }
    }
}






