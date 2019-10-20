using System;
using System.Collections.Generic;
namespace SK.StudentTranscript
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> courses = new List<String>();
            List<int> grades = new List<int>();
            List<int> credits = new List<int>();
          
            while (true)
            {
                Console.WriteLine("Ju lutem shkruani emrin e lendes, ose shkruani X per te vazhduar!");
                string courseName = Console.ReadLine();
                if (courseName == "X" || courseName == "x")
                    break;

                //courses[currentIndex] = courseName;
                courses.Add(courseName);

                while (true)
                {
                    Console.WriteLine("Ju lutem shkruani numrin e kredive per kete lende!");
                    int credit = Convert.ToInt32(Console.ReadLine());
                    if (credit >= 1 && credit <= 10)
                    {
                        credits.Add(credit);
                        break;
                    }
                }

                while (true)
                {
                    Console.WriteLine("Ju lutem shkruani noten per kete lende! \n Shkruani -1 per IN ose -2 per NR");
                    int grade = Convert.ToInt32(Console.ReadLine());

                    if ((grade >= 5 && grade <= 10) || grade == -1 || grade == -2)
                    {
                        grades.Add(grade);
                        break;
                        }
                    

                }

            }
            
         
            Console.WriteLine(courses[0] + " "+ grades[0]);
            Console.WriteLine("        TRANSKRIPTA E STUDENTIT");
            Console.WriteLine("=======================================");
            Console.WriteLine("| LENDA \t\t KREDITE \t NOTA");
            Console.WriteLine("=======================================");
            double shumaKredive = 0;
            double shumaNotave = 0;
            double shumaKredivePassed = 0;
            for (var i = 0; i<courses.Count; i++)
            {
                Console.Write(courses[i] + "\t\t" + credits[i] + "\t\t");

                if (grades[i] == -1)
                    Console.Write("IN");
                else if (grades[i] == -2)
                    Console.Write("NR");
                else
                    Console.Write(grades[i]);

                Console.WriteLine("");
                shumaKredive += credits[i];
                if (grades[i] > 5)
                {
                    shumaKredivePassed += credits[i];
                    shumaNotave += credits[i] * grades[i];
                }
            }
            double gpa = shumaNotave / shumaKredivePassed;
            
            Console.WriteLine("=======================================");
            Console.WriteLine("Nota mesatare: " + gpa.ToString("0.00"));
            Console.WriteLine("Credits Attempted: " + shumaKredive);
            Console.WriteLine("Credits Awarded: " + shumaKredivePassed);
            Console.WriteLine("Number of courses: " + courses.Count);
            Console.ReadLine();
        }
    }
}

