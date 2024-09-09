// See https://aka.ms/new-console-template for more information

Console.Write("Lütfen bir cümle girniz: ");
string? sentence = Console.ReadLine();
char[] character = {'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü', 'A', 'E', 'I', 'İ', 'O', 'Ö', 'U', 'Ü'};

List<char> result = new List<char>();
Console.WriteLine();
foreach (var item in sentence!)
{
    int index = character.ToList().IndexOf(item);
    if(index > -1)
      result.Add(character[index]);
}
result.Sort();
result.ForEach(x => Console.WriteLine(x));

