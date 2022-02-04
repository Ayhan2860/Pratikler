using System;
using System.Text.RegularExpressions;

namespace SessizHarf
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.Write("İfade giriniz : ");
            string expiression = "umut";
             int m = 0;
            int r = 0;
            Regex rgx = new Regex("[aeıioöuüAEIİUÜOÖ]");
            
            for (int i = 0; i < expiression.Length; i++)
            {  
                  var t = expiression[i].ToString();
                  var g = rgx.Match(t);
                 
                  if(!g.Success)
                  {
                    r++;
                    if(r>=3) m=0; else if(r>1) m =r;
                  }
                  else r=0;
            }
            if(m == 2)
             Console.WriteLine(true);
             else  
             Console.WriteLine(false);
            
          
            Console.ReadKey();
        }
    }
}
