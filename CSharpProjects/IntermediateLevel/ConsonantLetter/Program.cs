// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.Write("İfade giriniz : ");
List<string> words = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => arTemp).ToList();


Regex rgx = new Regex("[aeıioöuüAEIİUÜOÖ]");
string result = "";
foreach (var expiression in words)
{
    int m = 0;
    for (int i = 0; i < expiression.Length; i++)
    {

        int n = expiression.Length - 1;
        if (i < n)
        {
            var first = rgx.Match(expiression[i].ToString());
            var second = rgx.Match(expiression[i + 1].ToString());
            if (!first.Success && !second.Success)
            {
                m++;
            }
        }


    }
    if (m > 0)
        result += true + " ";
    else
        result += false + " ";

}
Console.WriteLine(result.TrimEnd());



Console.ReadKey();


