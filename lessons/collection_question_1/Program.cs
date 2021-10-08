using System;
using System.Collections;

namespace collection_question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ArrayList wandList = new ArrayList();
            ArrayList notWandList = new ArrayList();
            
            
            //Console.Write("Lütfen girmek istediğiniz sayı adedini giriniz : ");Convert.ToInt32(Console.ReadLine());
            int n = 20;
              
              
             for (int i =1 ; i <=n; i++)
            {
                 Console.WriteLine($"Lütfen {i}. sayıyı giriniz.");
                 string  value = Console.ReadLine();
                  int number;
                 bool result = int.TryParse(value, out number);
                 if(!result){
                      Console.WriteLine("Lütfen Sayısal bir değer giriniz");
                      break;
                 }
                 else if(number <=0){
                      Console.WriteLine("Lütfen pozitif bir sayı giriniz");
                       break;
                 }
                 else{
                 int counter = 0;
                  for (int j = 2; j < number; j++)
             {
                  if(number % j == 0){counter++;}
             }

              if(counter == 0){
               wandList.Add(number);
              }else{
                  notWandList.Add(number);
              }
            }
            }  
           
           
           Console.WriteLine("\n******* Asal Sayılar *******");
           wandList.Sort();
           wandList.Reverse();
           foreach (var item in wandList)
           {
               Console.WriteLine(item);
           }


          
           Console.WriteLine("\n******** Asal Olmayan Sayılar ******");
           notWandList.Sort();
           notWandList.Reverse();
           foreach (var item in notWandList)
           {
                Console.WriteLine(item);
           }

           // Asal sayıların toplam eleman sayısı ve ortalaması
            Console.WriteLine("\nAsal sayıların toplam eleman sayısı : "+wandList.Count);
            int wandTotal = 0;
            double wandAverage = 0;
           for (int i = 0; i < wandList.Count; i++)
           {
                wandTotal += Convert.ToInt32(wandList[i]);
                wandAverage = (double)wandTotal/(wandList.Count);
           }
           Console.WriteLine("Asal sayıların ortalama sayısı : "+ wandAverage);



             // Asal olmayan sayıların toplam eleman sayısı ve ortalaması
           Console.WriteLine("\nAsal olmayan sayıların toplam eleman sayısı : "+notWandList.Count);
           int notWandTotal = 0;
           double notWandAverage = 0;
           for (int i = 0; i < notWandList.Count; i++)
           {
                notWandTotal += Convert.ToInt32(notWandList[i]);
                notWandAverage = (double)notWandTotal/(notWandList.Count);
           }
           Console.WriteLine("Asal olmayan sayıların ortalama sayısı : "+ notWandAverage);
           



        }
    }
}
