using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {

            var oddEvenArray = new int[] { 10, 23, 44, 123, 55, 52, 98, 99, 102, 103, 152, 49 };
            var oddArray = new int[0];
            var evenArray = new int[0];
            for (int i = 0; i < oddEvenArray.Length; i++)
            {
                if (oddEvenArray[i] % 2 == 0)
                {
                    Array.Resize(ref evenArray, evenArray.Length + 1);
                    evenArray[evenArray.Length - 1] = oddEvenArray[i];
                }
                else
                {
                    Array.Resize(ref oddArray, oddArray.Length + 1);
                    oddArray[oddArray.Length - 1] = oddEvenArray[i];
                }
            }

            Console.WriteLine("Nizata parni broevi gi ima clenovite: ");
            foreach (var number in evenArray)
            {
                    Console.WriteLine(number);
            }

            Console.WriteLine("Nizata neparni broevi gi ima clenovite: ");
            foreach (var number in oddArray)
            {
                    Console.WriteLine(number);
            }
        }
    }
}
