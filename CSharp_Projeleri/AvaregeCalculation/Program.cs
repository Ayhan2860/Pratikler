using System;

namespace AvaregeCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
           
            FibonacciAverage averageResult = new FibonacciAverage();
            Console.Write ("Lütfen Bir Değer Giriniz : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write($"\nFibonaççi Sayılarının Toplamının Ortalaması :  {averageResult.FiboAverage(number)}");
            
         
            

            Console.ReadKey();
        }
    }
}
