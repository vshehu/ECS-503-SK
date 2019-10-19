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



            int i = 0; //current index
            while (true)
            {

                Console.WriteLine("Enter course name or enter 'X' to continue: ");
                string coursename = Console.ReadLine();
                if (coursename == "x" || coursename == "X")
                    break;

                Courses.Add(coursename);
                Courses[i] = coursename;

                Console.WriteLine("Register the grade for course: " + coursename);
                int coursegrade = Convert.ToInt32(Console.ReadLine());


                while ((coursegrade < 5 || coursegrade > 10) && (coursegrade != -2 && coursegrade != -1))
                {
                    Console.WriteLine("You entered invalid grade for course: " + coursename + " please try again!");
                    coursegrade = Convert.ToInt32(Console.ReadLine());
                }

                Grades.Add(coursegrade);
                Grades[i] = coursegrade;

                Console.WriteLine("Register the credits for course: " + coursename);
                int coursecredit = Convert.ToInt32(Console.ReadLine());

                while (coursecredit < 1 || coursecredit > 10)
                {
                    Console.WriteLine("You entered invalid credit for course: " + coursename + " please try again! ");
                    coursecredit = Convert.ToInt32(Console.ReadLine());
                }
                Credits.Add(coursecredit);
                Credits[i] = coursecredit;


                i++;
            }


            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("\t\t\t\tStudents Transkripts");

            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("\t\tCourses \t\t Grades\t\t Credits");
            Console.WriteLine("-------------------------------------------------------------------------");

            double sum = 0;
            double sumofcredits = 0;
            double creditpassed = 0;

            int j = 0;
            while (j < i)
            {
                if (Grades[j] < 0) // if we got grades that are IN and NR 
                {
                    if (Grades[j] == -1)

                        Console.WriteLine("\t\t" + Courses[j] + "\t\t\t" + "IN" + "\t\t\t" + Credits[j]);
                    else
                        Console.WriteLine("\t\t" + Courses[j] + "\t\t\t" + "NR" + "\t\t\t" + Credits[j]);
                }
                else
                    Console.WriteLine("\t\t" + Courses[j] + "\t\t\t" + Grades[j] + "\t\t\t" + Credits[j]);

                if (Grades[j] > 5) //calculate credits awarded
                {
                    creditpassed += Credits[j];
                    sum += Grades[j] * Credits[j];
                }

                sumofcredits += Credits[j];//calulate credits attempted
                j++;
            }

            double gpa = sum / creditpassed;

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Credits attempted: " + sumofcredits);
            Console.WriteLine("Credits awarded: " + creditpassed);
            Console.WriteLine("Number of courses: " + i);
            Console.WriteLine("GPA: " + gpa.ToString("0.00"));

            Console.ReadLine();
        }
    }
}
