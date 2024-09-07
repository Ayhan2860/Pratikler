// See https://aka.ms/new-console-template for more information
string variable = "Dersimiz CSharp, Hoşgeldiniz!";
string variable2 = "Dersimiz CSharp";
string variable3 = "dersimiz CSharp, Hoşgeldiniz!";
string variable4 = "CSharp";

//Length-uzunluk
Console.WriteLine("Length");
Console.WriteLine(variable.Length);

// ToUpper, ToLower - küçültme, büyültme
Console.WriteLine("\nToUpper-ToLower");
Console.WriteLine(variable.ToUpper());
Console.WriteLine(variable.ToLower());

//Concat - birleştirme
Console.WriteLine("\nConcat");
Console.WriteLine(String.Concat(variable + "Merhaba"));

//Compare CompareTo
Console.WriteLine("\nCompare-CompareTo");
Console.WriteLine(variable.CompareTo(variable2));  //variable == variable2 = 0 , variable.length > variable2.length = 1,  variable.length < variable2.length = -1
Console.WriteLine(String.Compare(variable, variable3, true));
Console.WriteLine(String.Compare(variable, variable3, false));

// Contains
Console.WriteLine("\nContains");
Console.WriteLine(variable.Contains(variable4));
Console.WriteLine(variable.EndsWith("Hoşgeldiniz!"));
Console.WriteLine(variable.EndsWith("Merhaba"));

//IndexOf
Console.WriteLine("\nIndexOf");
Console.WriteLine(variable.IndexOf("CS"));
Console.WriteLine(variable.IndexOf("Ayhan"));
//LastIndexOf
Console.WriteLine("\nLastIndexOf");
Console.WriteLine(variable.LastIndexOf("i"));

//Insert
Console.WriteLine("\nInsert");
Console.WriteLine(variable.Insert(0, "Merhaba "));

// PadLeft, PadRight
Console.WriteLine("\nPadLeft, PadRight");
Console.WriteLine(variable + variable2.PadLeft(30));
Console.WriteLine(variable + variable2.PadLeft(30, '*'));
Console.WriteLine(variable.PadRight(50) + variable2);
Console.WriteLine(variable.PadRight(50, '-') + variable2);


//Remove
Console.WriteLine("\nRemove");
Console.WriteLine(variable.Remove(10));
Console.WriteLine(variable.Remove(10, 3));
Console.WriteLine(variable.Remove(0, 1));


//Replace
Console.WriteLine("\nReplace");
Console.WriteLine(variable.Replace("CSharp", "C#"));
Console.WriteLine(variable.Replace(" ", "*"));

//Split
Console.WriteLine("\nSplit");
Console.WriteLine(variable.Split(' ')[2]);


//Substring
Console.WriteLine("\nSubstring");
Console.WriteLine(variable.Substring(4));
Console.WriteLine(variable.Substring(4, 6));
