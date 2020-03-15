using System;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            var appearances = 0;
            var arrayWithDuplicates = new int[] { 1, 4, 6, 3, 4, 5, 9, 3, 2, 9 };

            for (int i = 0; i < arrayWithDuplicates.Length; i++)
            {
                for (int j = i + 1; j < arrayWithDuplicates.Length; j++)
                {
                    if (arrayWithDuplicates[i] == arrayWithDuplicates[j])
                    {
                        appearances++;
                    }
                }
            }
            Console.WriteLine(appearances);
            Console.Read();
        }


            
        
    }
}
