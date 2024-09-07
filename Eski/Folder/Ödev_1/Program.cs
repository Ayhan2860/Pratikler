using System;
using System.Collections.Generic;

namespace Ödev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // 1. İster
            Console.WriteLine("***Ödev_1 / 1. İsterler***");
            Console.Write("Lütfen bir sayı giriniz : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n1; i++)
            {
                 if(i%2==0){
                     Console.WriteLine($"{i}");
                 }
               
            }

            // 2. İster
            Console.WriteLine("***Ödev_1 / 2. İsterler***");
            Console.Write("Lütfen birinci sayıyı giriniz : ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen ikinci sayıyı giriniz : ");
            int m1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n2; i++)
            {
               if (i == m1 )
               {
                   Console.WriteLine($"{n2} sayısının {m1} sayısına eşit olan sayısı : {i}");
               }else if( i%2==0){
                    Console.WriteLine($"{n2} sayısının tam bölünen sayısı : {i}"); 
               }  
            }

            // 3. İster
            Console.WriteLine("***Ödev_1 / 3. İsterler***");
            Console.Write("Lütfen bir sayı giriniz : ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] words = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Lütfen {i+1}. kelimeyi giriniz : ");
                words[i] = Console.ReadLine();
            }
            for (int i = words.Length-1; i >=0; i--)
            {
                Console.WriteLine($"{i+1}. kelime : " + words[i]);
            }*/

            // 4. İster
            
            Console.WriteLine("***Ödev_1 / 4. İsterler***");
            Console.Write("Lütfen bir cümle yazınız : \n");
            string sentence = Console.ReadLine();
            var charsToRemove = new string[] { "@", ",", ".", ";", "'","*","?" }; 
            foreach (var c in charsToRemove)
            {
                sentence = sentence.Replace(c, "");
            }
             Console.WriteLine(sentence);
            var result = sentence.Split(" ");
             Console.WriteLine("Cümle içinde toplam kelime sayısı : " +result.Length);
            var res = string.Join("",result);
             Console.WriteLine("Cümle içinde bulunan toplam harf sayısı : "+res.Length);
             
            

        

        }
    }
}
