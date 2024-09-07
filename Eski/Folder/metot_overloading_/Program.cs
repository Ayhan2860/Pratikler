using System;

namespace metot_overloading_
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametler
            string sayi = "999";
            int outSayi;
            bool result = int.TryParse(sayi,out outSayi);
            if (result)
            {
                Console.WriteLine("Başarılı!\n" + outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız!");

            }

          Metotlar metotlar = new Metotlar();
          metotlar.Topla(5,6,out int result2);
          Console.WriteLine(result2);
            
          int ifade = 999;
          metotlar.EkranaYazdir(Convert.ToString(ifade));
          metotlar.EkranaYazdir(ifade);
          metotlar.EkranaYazdir("Ayhan ", "Karaman");
          // Metot İmzası 
          // Metot Adı, Parametre Sayısı, Parametre
        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int result)
        {
             result = a+b;
        }

        public void EkranaYazdir(string veri){
            Console.WriteLine(veri);
        }

         public void EkranaYazdir(int veri){
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri, string veri2){
            Console.WriteLine(veri + veri2);
        }
    }
}
