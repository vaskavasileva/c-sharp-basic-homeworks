using System;
using System.Collections.Generic;
using System.Text;

namespace LottoServices
{
    public class LottoNumbersGenerator
    {
        public static int[] GenerateNumbers()
        {
            int[] winnigCombination = new int[7];
            for (int i = 0; i < winnigCombination.Length; i++)
            {
                int number = new Random().Next(1, 36);
                if (Array.IndexOf(winnigCombination,number) != -1)
                {
                    while (Array.IndexOf(winnigCombination, number) != -1)
                    {
                        number = new Random().Next(1, 36);
                    } 
                    
                }
                winnigCombination[i] = number;
            }
            return winnigCombination;
        }
    }
}
