using System;
using System.Collections.Generic;

namespace mutlak_kare
{
    public class AbsoluteSquare
    {
        public static void Squaring(List<int> arr)
        {
            int totalSum = 0;
            int sumTotal =0;

            for (int i = 0; i < arr.Count; i++)
            {
                if(arr[i] < 67)
                {
                  totalSum += 67 - arr[i]; 
                }

                else if(arr[i]> 67)
                {
                   
                    sumTotal += FindTheSquare(arr[i]-67);
                }
            }

            Console.Write($"\n\n{totalSum, 3}  -  {sumTotal}");
        }

        private static int FindTheSquare(int a)
        {
            return a * a;
        }
    }
}