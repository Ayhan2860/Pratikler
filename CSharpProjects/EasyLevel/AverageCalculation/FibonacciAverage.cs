

namespace AverageCalculation
{
     public static class FibonacciAverage
    {
       private static FibonacciLoop loop = new FibonacciLoop();
       private static double average;
       public static double FiboAverage(int n)
       {
         
           var totalFibonacci = loop.TotalFibonacci(n);
           average = (double)totalFibonacci / (double)n;
           Console.Write($"\nFibonaççi Sayılarının Toplamı : {totalFibonacci} ");
           return average;

       }
        

        
    }
}