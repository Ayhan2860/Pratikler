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

        /*
        Projede kullanıcı tarafında girilen bir sayı dizisinin 67'den küçük yada büyük olduğuna baktıktan sonra; 
        Küçük olanların farklarının toplamını 
        büyük ise de farkların mutlak karelerini alarak toplayıp ekrana yazdırdığımız bir Console uygulamamızdır.
        */

       
    }
}
