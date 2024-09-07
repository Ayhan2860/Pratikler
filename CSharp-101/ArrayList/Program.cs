// See https://aka.ms/new-console-template for more information


using System.Collections;

ArrayList list = new ArrayList();

// list.Add("Ayşe");
// list.Add(2);
// list.Add(true);
// list.Add('A');

//İçerisinde ki veriler erişim
//Console.WriteLine(list[1]);

// foreach (var item in list)
// {
//     Console.WriteLine(item);  
// }

//Addrange 
Console.WriteLine("***** Add Range *****");
//string[] colors = {"Kırmızı","Sarı","Yeşil"};
List<int> numbers = new List<int>() { 1, 5, 6, 8, 10, 4, 2 };
// list.AddRange(colors);
list.AddRange(numbers);

foreach (var item in list)
{
    Console.WriteLine(item);
}

// Sort -> Sıralama
Console.WriteLine("***** Sort *****");
list.Sort();
foreach (var item in list)
{
    Console.WriteLine(item);
}

// Binary Search
Console.WriteLine("***** Binary Search *****");
Console.WriteLine(list.BinarySearch(8));



//Reverse
Console.WriteLine("***** Reverse *****");
list.Reverse();
foreach (var item in list)
{
    Console.WriteLine(item);
}


//Clear
Console.WriteLine("***** Clear *****");
list.Clear();
foreach (var item in list)
{
    Console.WriteLine(item);
}
