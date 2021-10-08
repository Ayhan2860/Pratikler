using System;
using System.Collections.Generic;

namespace dictionary_list
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //System.Collection.Generic
            Dictionary<int,string> users = new Dictionary<int, string>();
            users.Add(10,"Ayhan Karaman");
            users.Add(12,"İlker Yiğitalp");
            users.Add(18,"Selçuk Bakış");
            users.Add(20,"Bülent Demir");

            //Dizinin elemanlarına erişim
            Console.WriteLine(users[12]);
            foreach (var item in users)
            {
                Console.WriteLine(item);
            }

            //Count
            Console.WriteLine("***** Count *****");
            Console.WriteLine(users.Count);

            //Contains
            Console.WriteLine("***** Contains *****");
            Console.WriteLine(users.ContainsKey(12));
            Console.WriteLine(users.ContainsValue("Ahmet Karaman"));

            // Remove
            Console.WriteLine("***** Remove *****");
            users.Remove(12);
            foreach (var item in users)
            {
                Console.WriteLine(item);
            }

            //Keys
            Console.WriteLine("***** Keys *****");
              foreach (var item in users)
            {
                Console.WriteLine(item.Key);
            }

            //Values
            Console.WriteLine("***** Values *****");
              foreach (var item in users)
            {
                Console.WriteLine(item.Value);
            } 
   
        }
    }
}
