using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                  Console.WriteLine("Bir sayı giriniz..");
                  int num = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine($"Girdiğinin Sayı : {num}");

            }
            catch (Exception ex)
            {
                
               Console.WriteLine($"Hata : {ex.Message.ToString()}");
            }
            finally{
                Console.WriteLine("İşlem Tamamlandı");
            }

            try
            {
                int c = int.Parse("-20000000000");
                //int a = int.Parse(null);
                //int b = int.Parse("test");
                

            }
            catch (ArgumentNullException ex)
            {
                
                 Console.WriteLine($"\nArgüman null hatası :\n {ex}");
            }
            catch(FormatException ex)  {
                 Console.WriteLine($"\nFormat hatası :\n {ex}");

            }
            catch(OverflowException ex){
                 Console.WriteLine($"\nOver flow hatası :\n {ex}");
            }
            

        Console.ReadKey();
          
        }
    }
}
