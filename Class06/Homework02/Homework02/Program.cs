using System;

namespace Homework02
{
    public enum Registration
    {
        passed = 1,
        notPassed
    }

    public enum Grades
    {
        Failure = 5,
        LowPass,
        Satisfactory,
        Good,
        Superior,
        Outstanding
    }

    class FirstCourse
    {
        public FirstCourse()
        {

        }
        public FirstCourse(string name, Registration didStudentPass)
        {
            CourseName = name;
            registration = didStudentPass;
        }

        public string CourseName;
        public Registration registration;

        public int Passed()
        {
            if (registration == Registration.passed)
            {
                return 1;
            }

            else
            {
                return 0;
            }
        }
    }

    class SecondCourse
    {
        public SecondCourse(string name, Grades studentGrade)
        {
            CourseName = name;
            grade = studentGrade;
        }

        public string CourseName;
        public Grades grade;


        public int Passed()
        {
            if (grade == Grades.Failure)
            {
                return 0;
            }

            else 
            {
                return 1;
            }
        }

        
    }

    class Project
    {

        public int[] ifPassed;
        public int sum = 0;

        public void Passed()
        {
            foreach (var eval in ifPassed)
            {
                sum += eval;
            }

            if (sum >= 3)
            {
                Console.WriteLine("The student has passed!");
            }
            else
            {
                Console.WriteLine("The student has failed!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var firstCourse1 = new FirstCourse("C#", Registration.passed);
            var firstCourse2 = new FirstCourse("C# Advanced", Registration.passed);
            var secondCourse1 = new SecondCourse("ASP.NET", Grades.Failure);
            var secondCourse2 = new SecondCourse("C# Server Development", Grades.Outstanding);

            var project = new Project
            {
                ifPassed = new int[4]
                {
                firstCourse1.Passed(),
                firstCourse2.Passed(),
                secondCourse1.Passed(),
                secondCourse2.Passed()
                }
            };

            project.Passed();

        }

        
        
    }
}


