using System;
using System.Collections.Generic;

namespace StudentTranscipt27159
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> courses = new List<string>();
            List<int> credits = new List<int>();
            List<int> grades = new List<int>();

            int currentIndex = 0;
            while (true)
            {
                string courseName;
                Console.WriteLine("Please enter course name or  type '0' to continue!");
                courseName = Console.ReadLine();
                if (courseName == "0")
                {
                    break;
                }
                courses.Add(courseName);
                int grade, credit;
                Console.WriteLine("Please register the grade for course:  " + courseName);
                grade = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < grade; i++)
                {
                    if ((i != -1 || i != -2) && (grade < 5 || grade > 10))
                    {
                        Console.WriteLine("Invalid grade entered:  " + courseName);
                        grade = Convert.ToInt32(Console.ReadLine());
                    }
                }

                grades.Add(grade);
                Console.WriteLine("Please register the credits for course:  " + courseName);
                credit = Convert.ToInt32(Console.ReadLine());

                while (credit < 1 || credit > 10)
                {
                    Console.WriteLine("Invalid credits entered:  " + courseName);
                    credit = Convert.ToInt32(Console.ReadLine());
                }

                credits.Add(credit);
                currentIndex++;
            }

            Console.WriteLine("            LIST OF COURSES");
            Console.WriteLine("=====================================");
            Console.WriteLine("COURSE NAME \t CREDITS \t GRADE");
            Console.WriteLine("=====================================");

            double sum = 0, sumOfCredits = 0, creditsPassed = 0;
            for (int i = 0; i < currentIndex; i++)
            {
                if (grades[i] < 0)
                {
                    if (grades[i] == -1)
                        Console.WriteLine(courses[i] + "\t\t" + credits[i] + "\t" + "IN");
                    else
                        Console.WriteLine(courses[i] + "\t\t" + credits[i] + "\t" + "NR");
                }
                else
                    Console.WriteLine(courses[i] + "\t\t" + credits[i] + "\t" + grades[i]);
                if (grades[i] > 5)
                {
                    creditsPassed += credits[i];
                    sum += grades[i] * credits[i];
                }
                sumOfCredits += credits[i];

            }
            double gpa = creditsPassed > 0 ? sum / creditsPassed : 0;

            Console.WriteLine("=====================================");
            Console.WriteLine("Credits attempted: " + sumOfCredits);
            Console.WriteLine("Credits awarded: " + creditsPassed);
            Console.WriteLine("Number of courses: " + currentIndex);
            Console.WriteLine("GPA: " + gpa.ToString("0.00"));

            Console.ReadLine();
        }
    }
}
