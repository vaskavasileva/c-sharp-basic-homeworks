using System;

namespace Homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Vaska";
            string lastName = "Vasileva";
            string name = firstName + " " + lastName;

            string number1 = "9";
            string number2 = "3";
            int num1 = Convert.ToInt32(number1);
            int num2 = Convert.ToInt32(number2);
            int summ = num1 + num2;

            Console.WriteLine("My name is: " + name);
            Console.WriteLine("The summ of the numbers is: " + summ);

        }
    }
}
