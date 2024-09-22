// See https://aka.ms/new-console-template for more information
Console.Write("Giriş yapacağınız kelime sayısı: ");
int wordNumber = Convert.ToInt32(Console.ReadLine());
string[] words = new string[wordNumber];
int i = 0;
while (i < wordNumber)
{
    Console.Clear();
    string readWord = "";
    Console.Write($"{i +1}. Kelime giriniz: ");
    readWord  = Console.ReadLine();
    Console.Write($"{i + 1}. Sayı giriniz: ");
    readWord += "," + Console.ReadLine();
    words[i] = readWord;
    i++;
}




Console.Clear();

foreach(string word in words)
{
   
    
    int position = word.IndexOf(",");
    string selectWord = word.Substring(0, position);
    Console.WriteLine($"{word} => {selectWord}");
}

Console.Read();


