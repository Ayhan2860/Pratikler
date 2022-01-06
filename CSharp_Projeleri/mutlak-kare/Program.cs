using System;
using System.Collections.Generic;
using System.Linq;

namespace mutlak_kare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayıları boşluk bırakarak giriniz : ");
            List<int>  arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
             AbsoluteSquare.Squaring(arr);
            Console.ReadLine();
        }

       
    }
}
