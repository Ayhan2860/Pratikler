using System;

namespace karakterTerstenYazma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("İfade giriniz :");
            var expression = Console.ReadLine();
          Console.WriteLine(ReverseString(expression));

        }

        private static string ReverseString(string value)
        {
            var expression = value.Split(" ");
            var firstLetter = "";
            var lastExpression = "";
            var result = "";

            for (int i = 0; i < expression.Length; i++)
            {
                firstLetter = expression[i].Substring(0, 1);
                lastExpression = expression[i].Remove(0, 1);
                result += string.Concat(lastExpression + firstLetter + " ");
                
            }

            return result;
        }
    }
}
