// See https://aka.ms/new-console-template for more information
using AbsoluteSquaring;

// Console.Write("Lütfen Hesaplama yapacağınız sayıyı giriniz :");
int s = 67; //Convert.ToInt32(Console.ReadLine());
Console.Write("\nSayıları boşluk bırakarak giriniz : ");


List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
AbsoluteSquare.Squaring(arr, s);
Console.ReadLine();
