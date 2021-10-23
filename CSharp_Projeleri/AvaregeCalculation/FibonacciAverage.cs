using System;

namespace AvaregeCalculation
{
   public  class FibonacciAverage
    {
       private FibonacciLoop loop = new FibonacciLoop();
       private double average;
       public double FiboAverage(int n)
       {
         
           var totalFibonacci = loop.TotalFibonacci(n);
           average = (double)totalFibonacci / (double)n;
           Console.Write($"\nFibonaççi Sayılarının Toplamı : {totalFibonacci} ");
           return average;

       }
        

        
    }
}
