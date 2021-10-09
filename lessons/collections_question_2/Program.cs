using System;

namespace collections_question_2
{
    class Program
    {
        static void Main(string[] args)
        {
           // Input number in 
           int[] numbers = new int [20];
           for(int i =0; i<numbers.Length;i++)
           {
             Console.Write($"Lüten {i+1}. sayıyı giriniz : ");
             numbers[i] = Convert.ToInt32(Console.ReadLine());
             Console.Clear();
           }
           Console.Clear();

           // Min. numbers and Max. numbers variables
           int[] mins = new int[3];
           int[] maxs = new int[3];

           //Min numbers avarege calculation
           int minTotal=0;
           double minAvarege=0;
            
            Array.Sort(numbers);
            for(int i = 0; i< mins.Length; i++)
            {
                mins[i] = numbers[i];
                minTotal += mins[i];
                minAvarege = (double)minTotal/(mins.Length);
            }

            //Max numbers avarege calculation
            int maxsTotal =0;
            double maxsAvarege=0;
            Array.Reverse(numbers);
            for(int i = 0; i< maxs.Length; i++)
            {
                maxs[i] = numbers[i];
                maxsTotal += maxs[i];
                maxsAvarege = (double)maxsTotal/(maxs.Length);
            }
            


            //Print to screen
            Console.WriteLine("***** Büyük Sayılar *****");
            
            foreach(var item in maxs)
            {
              Console.Write(item + ", ");
            }

            Console.WriteLine("\n***** Küçük Sayılar *****");
           foreach(var item in mins)
           {
              Console.Write(item + ", ");
           }
            Console.WriteLine($"\nBüyük sayıların Toplamı : {maxsTotal}");

            Console.WriteLine($"\nKüçük sayıların Toplamı : {minTotal}");

            Console.WriteLine($"\nBüyük sayıların ortalaması : {maxsAvarege}");

            Console.WriteLine($"\nKüçük sayıların ortalaması : {minAvarege}");
            
            Console.ReadKey();
        }
    }
}
