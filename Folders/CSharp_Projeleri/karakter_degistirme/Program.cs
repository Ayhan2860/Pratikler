using System;

namespace karakter_degistirme
{
    class Program
    {
        static void Main(string[] args)
        {
            string expiression = "Merhaba Hello Algoritma x";
            string result = "";

            // İfadeyi boşluklardan bölerek string array de saklamak
            string[] expiressionArray = expiression.Split(' ');
           
            // array'in uzunluğu kadar gezerek her bir kelimenin ilk karakteri ile son karakterin yerini değiştirmek
            for (var i = 0; i < expiressionArray.Length; i++)
            {
                int index = expiressionArray[i].Length-1;

                string firstCharacter = expiressionArray[i].Substring(0,1);
                string lastCharacter = expiressionArray[i].Substring(index);

                result += expiressionArray[i].Remove(0,1).Insert(0,lastCharacter)
                .Remove(index,1).Insert(index,firstCharacter + " ");
                
            }
             result = result.Substring(0,result.Length-1);
             Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
