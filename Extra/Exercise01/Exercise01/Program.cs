using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            int summ = 0;
            for (int i = 1; i <= 10 ; i++)
            {
                summ += i;
            }
            Console.WriteLine(summ);
        }
    }
}
