using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            var otherNumbers = new int[10];
            var numbers = new int[] { 5, 4, 6, 8, 7, 2, 9, 12, 54, 3 };
            Array.Copy(numbers, otherNumbers, 10);

            Array.Sort(otherNumbers);
            Console.WriteLine("The smallest number is: " + otherNumbers[0]);
            int smallest = otherNumbers[0];
            int indexSmallest = Array.IndexOf(numbers, otherNumbers[0]);
            Console.WriteLine("The index of that number is: " + indexSmallest);

            Array.Reverse(otherNumbers);
            Console.WriteLine("The largest number is: " + otherNumbers[0]);
            int largest = otherNumbers[0];
            int indexLargest = Array.IndexOf(numbers, otherNumbers[0]);
            Console.WriteLine("The index of that number is: " + indexLargest);
        }
    }
}
