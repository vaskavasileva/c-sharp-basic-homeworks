using System;

namespace Homework04
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "The whole group of G1 loves C#, we are sure that with their deducation and passion they will be successfull programers soon!";
            Console.WriteLine(sentence.Substring(sentence.IndexOf(',')+1)); 
        }
    }
}
