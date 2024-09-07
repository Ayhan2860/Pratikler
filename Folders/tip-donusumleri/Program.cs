using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion (Bilinçsiz Dönüşüm)
           Console.WriteLine("***** Implicit Conversion *****");

            byte a = 5;
            sbyte b = 30;
            short c = 10;
         

            int  d= a+b+c;
            Console.WriteLine($"d: {d}");

             long h = d;
             Console.WriteLine($"h: {h}");

             float i = h;
             Console.WriteLine($"i: {i}");

             
             string e = "Ayhan";
             char f = 'K';
             object g = e+f+d;

              Console.WriteLine($"g: {g}");

            // Explicit Conversion (Bilinçli Dönüşüm)
            Console.WriteLine("\n***** Explicit Conversion *****");

            int x = 4;
            byte y=(byte)x;
            Console.WriteLine($"y: {y,5}");

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine($"t: {t,5}");


            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine($"v: {v,5}");

            //  ToString Methodu
             Console.WriteLine("\n***** ToString Methodu *****");

             int xx = 6;
             string yy = xx.ToString();
             Console.WriteLine($"yy: {yy,5}");

             string zz = 12.5f.ToString();
             Console.WriteLine($"zz: {zz,5}");

             //System.Convert
              Console.WriteLine("\n***** System.Convert Sınıfı *****");
              string s1="10",s2="20";
              int sayi1, sayi2, toplam;

              sayi1 = Convert.ToInt32(s1);
              sayi2 = Convert.ToInt32(s2);

              toplam = sayi1 + sayi2;
              Console.WriteLine($"Toplam: {toplam,5}");


              // Parse
             Console.WriteLine("\n***** System.Convert Sınıfı *****");
             ParseMethod();


        }
        public static void  ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);
            Console.WriteLine($"Rakam : {rakam1}");
            Console.WriteLine($"Double : {double1}");

        }
    }
}
