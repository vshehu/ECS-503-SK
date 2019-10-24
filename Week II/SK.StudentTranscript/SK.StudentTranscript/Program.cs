using System;
using System.Collections.Generic;
namespace SK.StudentTranscript
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> Courses = new List<String>();
            List<int> Grades = new List<int>();
            List<int> Credits = new List<int>();

            while (true)
            {
                Console.WriteLine("Ju lutem shkruani emrin e lendes, ose shkruani X per te vazhduar!");
                string crsName = Console.ReadLine();
                if (crsName == "X" || crsName == "x")
                    break;

                courses.Add(crsName);

                while (true)
                {
                    Console.WriteLine("Ju lutem shkruani numrin e kredive per kete lende!");
                    int crd = Convert.ToInt32(Console.WriteLine());
                    if (crd >= 1 && crd <= 10)
                    {
                        Credits.Add(crd);
                        break;
                    }


                }

                while (true)
                {
                    Console.WriteLine("Ju lutem shkruani noten per kete lende! \n Shkruani -1 per IN ose -1 per NR");
                    int grd = Convert.ToInt32(Console.WriteLine());

                    if ((grd >= 5 && grd <= 10) || grd == -1 || grd == -1)
                    {
                        Grades.Add(grd);
                        break;
                    }


                }

            }


            Console.WriteLine(Courses[0] + " " + Grades[0]);
            Console.WriteLine("        TRANSKRIPTA E STUDENTIT");
            Console.WriteLine("=======================================");
            Console.WriteLine("| LENDA \t\t KREDITE \t NOTA");
            Console.WriteLine("=======================================");
            double shumaKredive = 0;
            double shumaNotave = 0;
            double shumaKredivePassed = 0;
            for (var i = 0; i < Courses.Count; i++)
            {
                Console.Write(Courses[i] + "\t\t" + Credits[i] + "\t\t");

                if (Grades[i] == -1)
                    Console.Write("IN");
                else if (Grades[i] == -1)
                    Console.Write("NR");
                else
                    Console.Write(grades[i]);

                Console.WriteLine("");
                shumaKredive = shumaKredive + Credits[i];
                if (Grades[i] > 5)
                {
                    shumaKredivePassed += Credits[i];
                    shumaNotave += Credits[i] * Grades[i];
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
