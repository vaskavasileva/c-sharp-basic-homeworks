using System;

namespace Homework08
{

    class Human
    {
        public string FirstName;
        public string LastName;
        public int Age;



        public void GetPersonStats()
        {
            Console.WriteLine("The name of the person is {0} {1} and the age is {2}", FirstName, LastName, Age);
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Human();
            Console.Write("Please enter your first name: ");
            person1.FirstName = Console.ReadLine();

            Console.Write("Please enter you last name: ");
            person1.LastName = Console.ReadLine();
            
            Console.Write("Please enter your age: ");
            while (true)
            {
                var inputAge = Console.ReadLine();
                var input = int.TryParse(inputAge, out person1.Age);
                if (input == false)
                {
                    Console.Write("Please enter a valid age: ");
                    continue;
                }
                break;
            }

            person1.GetPersonStats();
        }

        
    }
}
