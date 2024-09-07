using System;

namespace diziler_array_sinifi_metodlari
{
    class Program
    {
        static void Main(string[] args)
        {
           //Sort
            int[] sayiDizisi = {60,28,71,69,83,93,75,81};
            Console.WriteLine("***** Sırasız Dizi *****");
            foreach (var sayi in sayiDizisi)
            {
                Console.Write($"{sayi, -5}");
            }
             Console.WriteLine("\n***** Sıralı Dizi *****");
             Array.Sort(sayiDizisi);
             foreach (var sayi in sayiDizisi)
             {
                  Console.Write($"{sayi, -5}");
             }

             //Clear 
            Console.WriteLine("\n***** Array Clear *****");
            // sayiDizisi elemanlarını 2. index'ten başlayarak 2 elemanı 0 değerini atar.
            Array.Clear(sayiDizisi,2,2);
              foreach (var sayi in sayiDizisi)
             {
                  Console.Write($"{sayi, -5}");
             }

             //Reserve
             Console.WriteLine("\n***** Array Reverse *****");
             Array.Reverse(sayiDizisi);
               foreach (var sayi in sayiDizisi)
             {
                  Console.Write($"{sayi, -5}");
             }

             // IndexOf
            Console.WriteLine("\n***** Array IndexOf *****");
              Console.Write(Array.IndexOf(sayiDizisi,60));
              Console.Write(Array.IndexOf(sayiDizisi,28));

            // Resize
             Console.WriteLine("\n***** Array Resize *****");
             Array.Resize<int>(ref sayiDizisi,9);
             sayiDizisi[8] = 100;
                foreach (var sayi in sayiDizisi)
             {
                  Console.Write($"{sayi, -5}");
             }
        }
    }
}
