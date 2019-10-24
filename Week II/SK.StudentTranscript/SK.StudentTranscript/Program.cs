using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assingment1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Courses = new List<string>();
            List<int> Credits = new List<int>();
            List<int> Grades = new List<int>();
            int i = 0;
            while (true)
            {
                Console.WriteLine("shkruaj emrin e lendes ose 'X' per te vazhduar: ");
                string coursename = Console.ReadLine();
                if (coursename == "x" || coursename == "X")
                    break;
                Courses.Add(coursename);
                Console.WriteLine("shkruaj noten e lendes: " + coursename);
                int coursegrade = Convert.ToInt32(Console.ReadLine());
                while ((coursegrade < 5 || coursegrade > 10) && (coursegrade != -2 && coursegrade != -1))
                {
                    Console.WriteLine("ju keni shtypur gabim : " + coursename + " provo perseri!");
                    coursegrade = Convert.ToInt32(Console.ReadLine());
                }
                Grades.Add(coursegrade);
                Console.WriteLine("shkruaj kredit per lenden: " + coursename);
                int coursecredit = Convert.ToInt32(Console.ReadLine());
                while (coursecredit < 1 || coursecredit > 10)
                {
                    Console.WriteLine("ju keni shtypyr gabim: " + coursename + " provo perseri! ");
                    coursecredit = Convert.ToInt32(Console.ReadLine());
                }
                Credits.Add(coursecredit);
                i++;
            }
            Console.WriteLine("***********************************************");
            Console.WriteLine("\tStudents Transkripts");
            Console.WriteLine("***********************************************");
            Console.WriteLine("\tLenda \t Nota\t Kredit");
            Console.WriteLine("***********************************************");
            double sum = 0;
            double sumofcredits = 0;
            double creditpassed = 0;
            for (int k = 0; k < i; k++)
            {
                if (Grades[k] < 0)
                {
                    if (Grades[k] == -1)
                        Console.WriteLine("\t" + Courses[k] + "\t" + "in" + "\t" + Credits[k]);
                    else
                        Console.WriteLine("\t" + Courses[k] + "\t" + "nr" + "\t" + Credits[k]);
                }
                else
                    Console.WriteLine("\t" + Courses[k] + "\t" + Grades[k] + "\t" + Credits[k]);
                if (Grades[k] > 5)
                {
                    creditpassed += Credits[k];
                    sum += Grades[k] * Credits[k];
                }
                sumofcredits += Credits[k];

            }
            double gpa = sum / creditpassed;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Kredit e tentuara: " + sumofcredits);
            Console.WriteLine("Kredit e dhena: " + creditpassed);
            Console.WriteLine("Numri i lendve: " + i);
            Console.WriteLine("Mesatarja: " + gpa.ToString("0.00"));
            Console.ReadLine();
        }
    }
}