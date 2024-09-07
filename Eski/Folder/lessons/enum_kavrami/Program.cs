using System;

namespace enum_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine (Todays.Pazar);
            Console.WriteLine ((int)Todays.Cumartesi);

            int heat =32;
            if(heat <= (int)WeatherForecast.Normal)
            {
            Console.WriteLine ("Dışarıya çıkmak için havanın biraz daha ısınmasını bekle");
            }
            else if(heat >= (int)WeatherForecast.Sıcak)
            {
            Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
            }
            else if(heat >= (int)WeatherForecast.Normal && heat < (int)WeatherForecast.ÇokSıcak)
            {
            Console.WriteLine(" Hadi dışarı çıkalım");
            }
        }
    }

    enum Todays
{
  Pazartesi=1,

  Salı,

  Çarşamba,

  Perşembe,

  Cuma =23,

  Cumartesi,

  Pazar

}

enum WeatherForecast
{
  Soğuk = 5,

  Normal = 20,

  Sıcak = 25,

  ÇokSıcak = 30
}
}
