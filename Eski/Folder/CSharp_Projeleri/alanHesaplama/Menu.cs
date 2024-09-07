using System;

namespace alanHesaplama
{
    public class Menu
    {
          public static int MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Daire Alanını veya Çevresini Hesapla");
            Console.WriteLine("(2) Üçgen Alanını veya Çevresini Hesapla");
            Console.WriteLine("(3) Kare Alanını veya Çevresini Hesapla");
            Console.WriteLine("(4) Dikdörtgen  Alanını veya Çevresini Hesapla\n\n");
            Console.WriteLine("(5) Çıkış Yap\n");
            Console.Write("\nSeçiminiz : ");
            int vote = IntReadLineCheck();
            return vote;
        }

         public static int SubMenu(string subject)
        {
            Console.Clear();
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
            Console.WriteLine("*******************************************");
            Console.WriteLine($"(1) {subject} Çevresini Hesapla");
            Console.WriteLine($"(2) {subject} Alanını Hesapla\n");
            Console.Write("\nSeçiminiz : ");
            int n = IntReadLineCheck();
            Console.Clear();
            return n;
        }

       
        public static int IntReadLineCheck()
        {
            int number;
            try
            {
                 number = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.Exception)
            {
                
                number =0;
                Console.WriteLine("Lütfen sayısal bir seçim yapınız.");
            }
            return number;
        }
    }
}