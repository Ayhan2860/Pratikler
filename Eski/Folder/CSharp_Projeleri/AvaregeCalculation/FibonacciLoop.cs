using System;

namespace AvaregeCalculation
{
   public class FibonacciLoop
    {
        private int x=0;
        private int y =1;
        private int a =1;
        
        public int TotalFibonacci(int n)
        {
            Console.Write($"\nFibonaççi Sayıları : {x} { y}");
            for (int i = 1; i < n; i++)
            {
                 int z = x + y;
                 a += x + y;
                 Console.Write($" {z}");
                 x = y;
                 y = z ;
            }
          
           return a;

        }
        
       

    }
}
