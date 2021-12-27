using System;

namespace algoritma
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Lütfen kelime giriniz :");
             var inputValue = Console.ReadLine();
              
             var n = inputValue.Split(',');
             for (int i = 0; i < n.Length; i++)
             {
                 if(IsNumber(n[i]))
                 {
                     Console.WriteLine(n[i]);
                 }
               
             }
              
            Console.Read();
            
        }

        static bool IsNumber(string str)
        {
            for (int i = 0; i < str.Length; i++)
             {
                 if (char.IsNumber(str[i]))
                 {
                    return true;
                 }
                
             }
              return false;
        }
    }
}
