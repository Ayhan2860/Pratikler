using System;

public class Menu{
    public static int MenuListVote()
        {
            int vote;
            Console.Clear();
            Console.WriteLine("Lütfen yazdırmak istediğiniz üçgen türünü seçiniz");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Düz Üçgen");
            Console.WriteLine("(2) Ters Üçgen");
            Console.WriteLine("(3) İçi Boş Üçgen");
            Console.WriteLine("(4) Ortalı Piramit");
            Console.WriteLine("(5) Sola Yaslı Piramit");
            Console.WriteLine("(6) Sağa Yaslı Piramit");
            vote = Convert.ToInt32(Console.ReadLine());
            return vote;
        }
}