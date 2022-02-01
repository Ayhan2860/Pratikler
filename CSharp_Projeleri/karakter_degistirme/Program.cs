using System;

namespace karakter_degistirme
{
    class Program
    {
        static void Main(string[] args)
        {
            string expiression = "Merhaba Hello Algoritma x";
            string result = "";
            string[] expiressionArray = expiression.Split(' ');
            for (var i = 0; i < expiressionArray.Length; i++)
            {
                string firstCharacter = expiressionArray[i].Substring(0,1);
                string lastCharacter = expiressionArray[i].Substring(expiressionArray[i].Length-1);
                result += expiressionArray[i].Remove(0,1).Insert(0,lastCharacter)
                .Remove(expiressionArray[i].Length-1,1).Insert(expiressionArray[i].Length-1,firstCharacter + " ");
                
               
            }
             result = result.Substring(0,result.Length-1);
             Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
