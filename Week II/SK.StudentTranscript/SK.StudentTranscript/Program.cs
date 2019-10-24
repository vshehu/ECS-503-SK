using System;
using System.Collections.Generic;

namespace SK.StudentTranscript
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> courses = new List<string>();
            List<int> grades = new List<int>();
            List<int> allGrades = new List<int>();

            List<int> creditsAttempted = new List<int>();
            int creditsAwarded = 0;

            int currentIndex = 0;
            double shumaNotave = 0;
            int creditIndex = 0;

            while (true)
            {
                Console.WriteLine("\nJu lutem shkruani emrin e lendes, ose shkruani X per te mbyllur!");
                string courseName = Console.ReadLine();
                if (courseName == "X" || courseName == "x")
                    break;

                courses.Add(courseName);

                Console.WriteLine("Ju lutem shkruani numrin e kredive per kete lende! [1 - 10]");
                int credit = Convert.ToInt32(Console.ReadLine());


                while (credit < 1 || credit > 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Shifer e gabuar. Provoni perseri.\nJu lutem shkruani numrin e kredive per kete lende! [1 - 10]");
                    Console.ForegroundColor = ConsoleColor.White;
                    credit = Convert.ToInt32(Console.ReadLine());
                }

                creditsAttempted.Add(credit);

                Console.WriteLine("Ju lutem shkruani noten per kete lende! [5 - 10] | Shenoni 11 per IN dhe 12 per NR");
                int grade = Convert.ToInt32(Console.ReadLine());


                while (grade < 5 || grade > 12)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Shifer e gabuar. Provoni perseri.\nJu lutem shkruani noten per kete lende! [5 - 10] | Shenoni -1 per IN dhe -2 per NR");
                    Console.ForegroundColor = ConsoleColor.White;
                    grade = Convert.ToInt32(Console.ReadLine());
                }


                allGrades.Add(grade);

                if (grade > 5 && grade < 11 && grade != 11 && grade != 12) 
                {
                    grades.Add(grade);
                    creditsAwarded += credit;

                    shumaNotave += credit * grades[creditIndex];
                    creditIndex++;
                }

                currentIndex++;
            }

            Console.WriteLine("\n\n        TRANSKRIPTA E STUDENTIT");
            Console.WriteLine("=======================================");
            Console.WriteLine("\tLENDA\tKREDITE\tNOTA");
            Console.WriteLine("=======================================");

            double shumaKrediveAttempted = 0;


            for (var i = 0; i < currentIndex; i++)
            {
                Console.WriteLine("\t" + courses[i] + "\t" + creditsAttempted[i] + "\t" + allGrades[i].ToString().Replace("11", "IN").Replace("12", "NR"));
                shumaKrediveAttempted += creditsAttempted[i];
            }

            double gpa = shumaNotave / creditsAwarded;

            Console.WriteLine("=======================================");
            Console.WriteLine("Number of courses: " + currentIndex.ToString());
            Console.WriteLine("Credites attempted: " + shumaKrediveAttempted.ToString());
            Console.WriteLine("Credites awarded: " + creditsAwarded.ToString());

            Console.WriteLine("GPA: " + gpa.ToString("0.00"));
            Console.ReadLine();
        }
    }
}






