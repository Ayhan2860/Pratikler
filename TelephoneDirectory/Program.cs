using System;

namespace TelephoneDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryManager manager = new DirectoryManager();
            manager.Add(new Directory{Id = 1,FirstName ="Ayhan", LastName = "Karaman", PhoneNumber = "04542633446"});

            Console.WriteLine("\n***** Rehber Listesi *****");
            foreach (var item in manager.GetList())
            {
                
                Console.WriteLine($"{item.FirstName} { item.LastName}\n");
            }
 
 

         






            Console.ReadKey();
        }
    }
}
