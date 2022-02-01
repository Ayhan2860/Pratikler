using System;
using System.Collections.Generic;
using System.Linq;

namespace mutlak_kare
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Lütfen Hesaplama yapacağınız sayıyı giriniz :");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nSayıları boşluk bırakarak giriniz : ");

           
            List<int>  arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
             AbsoluteSquare.Squaring(arr,s);
            Console.ReadLine();
        }

      
       
    }
}
