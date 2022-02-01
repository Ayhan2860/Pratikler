using System;
using System.Collections.Generic;

namespace mutlak_kare
{
    public class AbsoluteSquare
    {

       
        /// <summary>
        /// Belirlenmiş bir sayının kendinden küçük olan sayıların farklarının toplamını ve
        /// kendinden büyük olan sayıların farklarının mutlak karesini toplamını hesaplar
        ///</summary>
        /// <param name="arr">Sayıların listesi</param>
        /// <param name="s">Belirlenmiş sayı</param>
        public static void Squaring(List<int> arr, int s)
        {
            int totalSum = 0;
            int sumTotal =0;

            for (int i = 0; i < arr.Count; i++)
            {
                if(arr[i] < s)
                {
                  totalSum += Math.Abs(s - arr[i]); 
                }

                else if(arr[i]> s)
                {
                   
                    sumTotal += FindTheSquare(arr[i]-s);
                }
            }

            Console.Write($"\n\n{totalSum, 3}  {sumTotal}");
        }
         /// <summary>
        /// Belirlenmiş bir sayının kendinden küçük olan sayıların farklarının toplamını ve
        /// kendinden büyük olan sayıların farklarının mutlak karesini toplamını hesaplar
        ///</summary>
        /// <param name="a">Belirlenmiş sayı</param>
        /// <returns>Sayının mutlak karesi</returns>
        private static int FindTheSquare(int a)
        {
            return a * a;
        }
    }
}