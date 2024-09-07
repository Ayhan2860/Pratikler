using System;

namespace AvaregeCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
           
             
            Console.Write ("Lütfen Bir Değer Giriniz : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write($"\nFibonaççi Sayılarının Toplamının Ortalaması :  {FibonacciAverage.FiboAverage(number)}");
            
         
            

            Console.ReadKey();
        }
    }
}
