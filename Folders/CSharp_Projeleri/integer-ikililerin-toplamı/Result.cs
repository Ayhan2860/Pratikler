using System;
using System.Collections.Generic;

namespace integer_ikililerin_toplamı
{
    public class Result
    {
        public static List<int>  BinaryNumbersSum(List<int> arr)
        {
              List<int> sums = new List<int>();
             for (int i = 0, j = 1; i < arr.Count; i +=2, j +=2)
            {
              
                    if (arr[i] == arr[j])
                    {
                        sums.Add((arr[i] + arr[j]) * (arr[i] + arr[j]));
                  
                       
                    }
                    else
                    {
                         sums.Add((arr[i] + arr[j]));
                      
                     
                    }
                  
                
            }

            return sums;

        }
    }
}