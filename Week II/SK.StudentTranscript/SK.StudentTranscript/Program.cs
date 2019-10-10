using System;

namespace SK.StudentTranscript
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] courses = new string[20];
            int[] grades = new int[20];
            int[] credits = new int[20];
            int currentIndex = 0;
            while (true)
            {
                Console.WriteLine("Ju lutem shkruani emrin e lendes, ose shkruani X per te vazhduar!");
                string courseName = Console.ReadLine();
                if (courseName == "X" || courseName == "x")
                    break;

                courses[currentIndex] = courseName;

                Console.WriteLine("Ju lutem shkruani numrin e kredive per kete lende!");
                int credit = Convert.ToInt32(Console.ReadLine());
                credits[currentIndex] = credit;

                Console.WriteLine("Ju lutem shkruani noten per kete lende!");
                int grade = Convert.ToInt32(Console.ReadLine());
                grades[currentIndex] = grade;
                currentIndex++;
            }
            
            Console.WriteLine("        TRANSKRIPTA E STUDENTIT");
            Console.WriteLine("=======================================");
            Console.WriteLine("| LENDA \t\t KREDITE \t NOTA");
            Console.WriteLine("=======================================");
            double shumaKredive = 0;
            double shumaNotave = 0;
            for (var i = 0; i<currentIndex; i++)
            {
                Console.WriteLine(courses[i] + "\t\t" + credits[i] + "\t" + grades[i]);
                shumaKredive += credits[i];
                shumaNotave += credits[i] * grades[i];
            }
            double gpa = shumaNotave / shumaKredive;

            Console.WriteLine("=======================================");
            Console.WriteLine("Nota mesatare: " + gpa.ToString("0.00"));
            Console.ReadLine();
        }
    }
}






