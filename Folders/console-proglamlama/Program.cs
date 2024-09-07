using System;

namespace console_proglamlama
{
    class Program
    {
        static void Main(string[] args)
        {
               Console.WriteLine("Adınızı giriniz.");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz");
            string surname = Console.ReadLine();

            Console.WriteLine($"Merhaba {name.ToUpper()} {surname.ToUpper()}");

            Console.ReadLine();
        }
    }
}
