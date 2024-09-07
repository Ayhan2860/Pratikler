using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
namespace integer_ikililerin_toplamı
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayıları aralarında boşluk bırakarak giriniz : ");
       

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
           
            List<int> sums = Result.BinaryNumbersSum(arr);

            foreach (var item in sums)
          {
              Console.Write(item + " ");
          }

          
       Console.ReadLine();
         }
    }
}
