using System;

namespace Homework05
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("year:" + now.Year);
            Console.WriteLine("month:" + now.Month);
            Console.WriteLine("day:" + now.Day);
            Console.WriteLine("hour:" + now.Hour);
            Console.WriteLine("minute:" + now.Minute);
            Console.WriteLine("second:" + now.Second);
        }
    }
}
